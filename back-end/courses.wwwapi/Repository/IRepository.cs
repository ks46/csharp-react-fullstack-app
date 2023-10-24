using courses.wwwapi.EndPoints;
using courses.wwwapi.Models;

namespace courses.wwwapi.Repository
{
    public interface IRepository
    {
        Student? GetStudent(int studentId);
        IEnumerable<Course> GetCourses(int studentId);
    }
}
