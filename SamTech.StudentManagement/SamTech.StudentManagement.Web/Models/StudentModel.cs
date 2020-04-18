using SamTech.StudentManagement.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;

namespace SamTech.StudentManagement.Web.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        //private readonly IStudentService _studentService;

        //public StudentModel(IStudentService studentService)
        //{
        //    _studentService = studentService;
        //}

        //public StudentModel()
        //{

        //}

        public void createStudent()
        {
            var student = new Student
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            };
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.addStudent(student);

        }
    }
}
