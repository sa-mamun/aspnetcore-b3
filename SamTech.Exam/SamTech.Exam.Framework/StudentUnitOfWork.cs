using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class StudentUnitOfWork : UnitOfWork, IStudentUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public IGradeRepository GradeRepository { get; set; }

        public StudentUnitOfWork(FrameworkContext context, IStudentRepository studentRepository, ISubjectRepository subjectRepository
            , IGradeRepository gradeRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
            SubjectRepository = subjectRepository;
            GradeRepository = gradeRepository;
        }
    }
}
