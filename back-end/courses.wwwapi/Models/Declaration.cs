using System.ComponentModel.DataAnnotations.Schema;

namespace courses.wwwapi.Models
{
    public class Declaration
    {
        public int id { get; set; }

        [ForeignKey("Student")]
        public int studentId { get; set; }
        public DateTime examsPeriod { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
