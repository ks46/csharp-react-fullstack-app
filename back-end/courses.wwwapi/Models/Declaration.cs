﻿namespace courses.wwwapi.Models
{
    public class Declaration
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public DateTime examsPeriod { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}