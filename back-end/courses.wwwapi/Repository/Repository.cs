using courses.wwwapi.Data;
using courses.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace courses.wwwapi.Repository
{
    public class Repository : IRepository
    {
        public Student? GetStudent(int studentId)
        {
            using (var db = new DataContext())
            {
                return db.Students.SingleOrDefault(s => s.id == studentId);
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
