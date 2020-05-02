using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public interface ISubjectRepository : IRepository<Subject, int, FrameworkContext>
    {

    }
}
