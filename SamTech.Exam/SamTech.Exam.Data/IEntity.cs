using System;

namespace SamTech.Exam.Data
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
