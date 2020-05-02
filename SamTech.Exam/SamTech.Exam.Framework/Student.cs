using SamTech.Exam.Data;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SamTech.Exam.Framework
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public IList<Grade> Subjects { get; set; }
    }
}
