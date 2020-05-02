using SamTech.Exam.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public class GradeRepository : Repository<Grade, int, FrameworkContext>, IGradeRepository
    {
        public GradeRepository(FrameworkContext context)
            : base(context)
        {

        }
    }
}
