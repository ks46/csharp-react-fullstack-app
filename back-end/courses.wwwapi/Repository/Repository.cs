using courses.wwwapi.Data;
using courses.wwwapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace courses.wwwapi.Repository
{
    public class Repository : IRepository
    {
        public Student? GetStudent(int studentId)
        {
            using (var db = new DataContext())
            {
                // display results about USP requirements
                Student? student = db.Students.SingleOrDefault(s => s.id == studentId);
                if (student == null)
                    return null;

                // retrieve all information about courses successfully passed by this student
                if (db.Declarations == null)
                    return student;
                /** TODO: use Entity Framework version 8 in order to be able to use a single query
                 * that returns all results as needed, as explained here:
                 * https://timdeschryver.dev/blog/you-can-now-return-unmapped-types-from-raw-sql-select-statements-with-entity-framework-8

                    SELECT c.description, SUM(c.ects), COUNT(*) FROM "Courses" c
                    WHERE c.id IN (
                        SELECT cd."courseId"
                        FROM "Declarations" d
                        INNER JOIN "CoursesDeclarations" cd ON cd."declarationId" = d.id
                        WHERE d."studentId" = 1
                        AND cd.grade >= 5.0
                    )
                    GROUP BY c.description
                    ;
                 */
                int ects = db.Database.SqlQuery<int>($"SELECT SUM(c.ects) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = 1 )").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{ects} / 240 ECTS", done = ects >= 240 });

                int result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'Compulsory courses')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 18 compulsory courses", done = result == 18 });

                result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'Track Compulsory courses')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 4 track compulsory courses", done = result >= 4 });

                result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'Project')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 1 track project", done = result >= 1 });

                result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'Elective Specialization courses')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 4 core specialization courses", done = result >= 4 });

                result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'General Education')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 3 general education", done = result == 3 });

                result = db.Database.SqlQuery<int>($"SELECT COUNT(*) FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = {studentId} AND cd.grade >= 5.0 AND c.description = 'Thesis/Internship')").ToList()[0];
                student.requirements.Add(new Requirement() { text = $"{result} / 2 thesis and/or internship", done = result >= 2 });

                return student;
            }
            return null;
        }
        
        public IEnumerable<Course> GetCourses(int studentId)
        {
            using (var db = new DataContext())
            {
                // return all courses, with their specializations info
                List<Course> courses =  db.Courses.Include(c => c.specializations).ToList();
                if (courses == null)
                    return null;

                // mark courses that have been successfully passed as not-available to use in current declaration
                var results = db.Database.SqlQuery<int>($"SELECT cd.\"courseId\" FROM \"CoursesDeclarations\" cd INNER JOIN \"Declarations\" d ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = 1 AND cd.grade >= 5.0").ToList();

                foreach (Course course in courses)
                {
                    if (results.Exists(id => id == course.id))
                        course.isAvailable = false;
                }

                return courses;
            }
            return null;
        }

        public Declaration? CreateDeclaration(int studentId, List<int> courseIds)
        {
            using (var db = new DataContext())
            {
                // ensure that student with such studentId exists
                if (db.Students.SingleOrDefault(s => s.id == studentId) == null)
                    return null;

                // create a new Declaration object
                DateTime dt = DateTime.UtcNow;
                Declaration d = new Declaration()
                {
                    studentId = studentId,
                    period = "Winter 2023",
                    createdAt = dt,
                    updatedAt = dt
                };
                db.Declarations.Add(d);
                db.SaveChanges();

                // for each courseId, create a new CoursesDeclarations object
                courseIds.ForEach(courseId =>
                {
                    db.CoursesDeclarations.Add(new CoursesDeclarations()
                    {
                        courseId = courseId,
                        declarationId = d.id,
                        grade = 0,
                        createdAt = dt,
                        updatedAt = dt
                    });
                });
                db.SaveChanges();

                return d;
            }
            return null;
        }

        public Declaration? GetDeclaration(int studentId, int declarationId)
        {
            using (var db = new DataContext())
            {
                // ensure that student with such studentId exists
                if (db.Students.SingleOrDefault(s => s.id == studentId) == null)
                    return null;

                // find declaration with such declarationId
                Declaration? d = db.Declarations.Include(d => d.courses).ThenInclude(cd => cd.course).SingleOrDefault(d => d.id == declarationId);
                return d;
            }
            return null;
        }
    }
}
