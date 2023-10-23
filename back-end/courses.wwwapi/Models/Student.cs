namespace courses.wwwapi.Models
{
    public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string code { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string department { get; set; }
        public string faculty { get; set; }
        public int semester { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
