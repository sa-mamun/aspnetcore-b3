using Autofac;
using SamTech.StudentManagement.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.StudentManagement.Web.Models
{
    public class CourseModel
    {
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }

        public void createCourse()
        {
            var course = new Course
            {
                Title = this.Title,
                SeatCount = this.SeatCount,
                Fee = this.Fee
            };

            var service = Startup.AutofacContainer.Resolve<ICourseService>();
            service.addCourse(course);
        }
    }
}
