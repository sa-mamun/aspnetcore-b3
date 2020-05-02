using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class GradeService : IGradeService
    {
        private readonly IStudentUnitOfWork _studentUnitOfWork;

        public GradeService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void AddGrade(Grade grade)
        {
            _studentUnitOfWork.GradeRepository.Add(grade);
            _studentUnitOfWork.Save();
        }

        public void Dispose()
        {
            _studentUnitOfWork?.Dispose();
        }
    }
}
