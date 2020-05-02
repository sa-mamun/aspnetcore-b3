using System;
using System.Collections.Generic;
using System.Text;

namespace SamTech.Exam.Framework
{
    public interface ISubjectService : IDisposable
    {
        void AddSubject(Subject subject);
        (IList<Subject> records, int total, int totalDisplay) GetSubjects(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
    }
}
