using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public interface IGradeService : IDisposable
    {
        void AddGrade(Grade grade);
    }
}
