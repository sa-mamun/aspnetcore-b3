using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.StudentManagement.Framework
{
    public interface IStudentService
    {
        void addStudent(Student student);
        Student getStudentById(int id);
    }
}
