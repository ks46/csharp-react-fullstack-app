using System.ComponentModel.DataAnnotations.Schema;

namespace courses.wwwapi.Models
{
    public class CoursesSpecializations
    {
        [ForeignKey("Course")]
        public int courseId { get; set; }

        public int specializationId { get; set; }
        public string category { get; set; }
    }
}
