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
                // TODO: display results about USP requirements
                Student? student = db.Students.SingleOrDefault(s => s.id == studentId);
                if (student == null)
                    return null;

                // retrieve all information about courses successfully passed by this student
                if (db.Declarations == null)
                    return student;

                // List<Declaration> results = db.Declarations.Include(d => d.courses).ToList().FindAll(d => d.studentId == studentId);

                // var results = db.Courses.FromSql($"SELECT c.description as id, SUM(c.ects) as ects, COUNT(c.id) as ,  FROM \"Courses\" c WHERE c.id IN (SELECT cd.\"courseId\" FROM \"Declarations\" d INNER JOIN \"CoursesDeclarations\" cd ON cd.\"declarationId\" = d.id WHERE d.\"studentId\" = 1 AND cd.grade >= 5.0) GROUP BY c.description;").ToList();

                /** TODO: get results of this query
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

                int ects = 0;
                /**
                 * for each result of SQL query above,
                 * create the requirement element
                */

                student.requirements.Add(new Requirement() { text = "?? / 240 ECTS", done = false });
                student.requirements.Add(new Requirement() { text = "?? / 18 compulsory courses", done = false });
                student.requirements.Add(new Requirement() { text = "?? / 4 track compulsory courses", done = false });
                student.requirements.Add(new Requirement() { text = "?? / 1 track project", done = false });
                student.requirements.Add(new Requirement() { text = "?? / 4 core specialization courses", done = false });
                student.requirements.Add(new Requirement() { text = "?? / 3 general education", done = false });
                student.requirements.Add(new Requirement() { text = "?? / thesis and/or internship", done = false });

                return student;
            }
            return null;
        }
        
        public IEnumerable<Course> GetCourses(int studentId)
        {
            using (var db = new DataContext())
            {
                // TODO: mark as non-available to be declared all courses that this student has successfully passed
                // return all courses, with their specializations info
                return db.Courses.Include(c => c.specializations).ToList();
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
