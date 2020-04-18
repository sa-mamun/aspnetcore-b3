using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.StudentManagement.Framework
{
    public class CourseService : ICourseService
    {
        private IStudentUnitOfWork _studentUnitOfWork;

        public CourseService(IStudentUnitOfWork studentUnitOfWork)
        {
            _studentUnitOfWork = studentUnitOfWork;
        }
        public void addCourse(Course course)
        {
            _studentUnitOfWork.CourseRepository.Add(course);
            _studentUnitOfWork.Save();
        }
    }
}
