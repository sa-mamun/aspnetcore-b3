﻿using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class Subject : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public IList<Grade> Students { get; set; }
    }
}
