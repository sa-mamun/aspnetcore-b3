using Autofac;
using SamTech.Exam.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamTech.Exam.Web.Models
{
    public class GetSubjectModel
    {
        protected ISubjectService _subjectService;

        public GetSubjectModel()
        {
            _subjectService = Startup.AutofacContainer.Resolve<ISubjectService>();
        }

        internal object GetSubjects(DataTablesAjaxRequestModel tableModel)
        {
            var data = _subjectService.GetSubjects(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "RegistrationOpen" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.RegistrationOpen.ToString()
                        }
                    ).ToArray()

            };

        }
    }
}
