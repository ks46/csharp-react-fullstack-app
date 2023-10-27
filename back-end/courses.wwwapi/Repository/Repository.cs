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
                // return all courses, with their specializations info
                return db.Courses.Include(c => c.specializations).ToList();
            }
            return null;
        }

        public Declaration? CreateDeclaration(int studentId, List<int> courseIds)
        {
            using (var db = new DataContext())
            {
                // ensure that such studentId exists
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

                /*
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
                */

                db.SaveChanges();
                return d;
            }
            return null;
        }
    }
}
