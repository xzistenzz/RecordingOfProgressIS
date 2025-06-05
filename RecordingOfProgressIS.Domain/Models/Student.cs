﻿namespace RecordingOfProgressIS.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MailAdress { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public List<Grade> Grades { get; set; }
    }
}

