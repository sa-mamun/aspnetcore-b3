using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class Grade : IEntity<int>
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Grad { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
