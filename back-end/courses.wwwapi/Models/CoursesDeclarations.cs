using System.ComponentModel.DataAnnotations.Schema;

namespace courses.wwwapi.Models
{
    public class CoursesDeclarations
    {
        [ForeignKey("Course")]
        public int courseId { get; set; }

        [ForeignKey("Declaration")]
        public int declarationId { get; set; }
        public decimal grade { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
