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
                // TODO: return all courses, with their specialization info, ordered by semester
                return db.Courses.Include(c => c.specializations).ToList();
            }
            return null;
        }
    }
}
