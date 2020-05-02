using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class StudentService : IStudentService
    {
        private readonly IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }
        
        public void AddStudent(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public void Dispose()
        {
            _studentUnitOfWork?.Dispose();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _studentUnitOfWork.StudentRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
