using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.StudentManagement.Framework
{
    public class StudentService : IStudentService
    {
        private IStudentUnitOfWork _studentUnitOfWork;

        public StudentService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }

        public void addStudent(Student student)
        {
            _studentUnitOfWork.StudentRepository.Add(student);
            _studentUnitOfWork.Save();
        }

        public Student getStudentById(int id)
        {
            return _studentUnitOfWork.StudentRepository.GetById(id);
        }

        //public void addCourse(Course course)
        //{
        //    _studentUnitOfWork.CourseRepository.Add(course);
        //    _studentUnitOfWork.Save();
        //}
    }
}
