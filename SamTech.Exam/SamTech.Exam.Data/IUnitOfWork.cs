using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
