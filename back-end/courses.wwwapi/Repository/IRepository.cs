using courses.wwwapi.EndPoints;
using courses.wwwapi.Models;

namespace courses.wwwapi.Repository
{
    public interface IRepository
    {
        IEnumerable<Student> GetStudent(int studentId);
    }
}
