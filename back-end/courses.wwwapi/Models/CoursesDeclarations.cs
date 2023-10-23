namespace courses.wwwapi.Models
{
    public class CoursesDeclarations
    {
        public int declarationId { get; set; }
        public int courseId { get; set; }
        public decimal grade { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
