using System.Collections.Generic;
using System.Linq;
using ALLINONE.DATA;

namespace ALLINONE.SERVICE
{
  public  class StudentRepository:IStudentRepository
    {
        ProjectContex _context = new ProjectContex();
      public Student GetById(int id)
      {
          var result = (from r in _context.Students
              where r.StudentId == id
              select r).FirstOrDefault();
          return result;
      }

      public void Insert(Student model)
      {
          _context.Students.Add(model);
          _context.SaveChanges();
      }

      public void Update(Student model)
      {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }

      public void Delete(Student model)
      {
          _context.Students.Find(model);
          _context.Students.Remove(model);
          _context.SaveChanges();


      }

      public IEnumerable<Student> GetStudents()
      {
          return _context.Students;
      }
    }
}
