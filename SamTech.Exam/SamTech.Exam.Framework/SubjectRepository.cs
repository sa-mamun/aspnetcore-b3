using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class SubjectRepository : Repository<Subject, int, FrameworkContext>, ISubjectRepository
    {
        public SubjectRepository(FrameworkContext context)
            : base(context)
        {

        }
    }
}
