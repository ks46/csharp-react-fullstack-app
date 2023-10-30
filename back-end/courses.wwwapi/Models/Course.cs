using System.ComponentModel.DataAnnotations.Schema;

namespace courses.wwwapi.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        // public string code { get; set; }
        public int ects { get; set; }
        public int semester { get; set; }
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<CoursesSpecializations> specializations { get; set; } = new List<CoursesSpecializations>();

        [NotMapped]
        public bool isAvailable { get; set; } = true;
    }
}
