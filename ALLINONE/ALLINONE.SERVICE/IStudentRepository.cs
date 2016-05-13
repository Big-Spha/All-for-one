using System;
using System.Collections.Generic;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
    public interface IStudentRepository
    {
        Student GetById(Int32 id);
        void Insert(Student model);
        void Update(Student model);
        void Delete(Student model);
        IEnumerable<Student> GetStudents();
    }
}
