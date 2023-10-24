using courses.wwwapi.Data;
using courses.wwwapi.Models;

namespace courses.wwwapi.Repository
{
    public class Repository : IRepository
    {
        Student IRepository.GetStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses(int studentId)
        {
            using (var db = new DataContext())
            {
                // TODO: return all courses, with their specialization info, ordered by semester
                return db.Courses.ToList();
            }
            return null;
        }
    }
}
