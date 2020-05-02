using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class AddGradeModel : IDisposable
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal Grad { get; set; }

        protected IGradeService _gradeService;

        public AddGradeModel()
        {
            _gradeService = Startup.AutofacContainer.Resolve<IGradeService>();
        }

        public void AddGrade()
        {
            var grade = new Grade
            {
                StudentId = this.StudentId,
                SubjectId = this.SubjectId,
                Grad = this.Grad
            };

            _gradeService.AddGrade(grade);
        }

        public void Dispose()
        {
            _gradeService?.Dispose();
        }
    }
}
