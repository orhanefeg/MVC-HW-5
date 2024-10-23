using BLL.DAL;
using BLL.Models;
using BLL.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IStudentService
    {
        public Service Create(Student student);
        public Service Update(Student student);
        public Service Delete(int id);
        public IQueryable<StudentModel> Query();

    }
    public class StudentService : Service, IStudentService
    {
        public StudentService(Db db) : base(db)
        {
        }

        public Service Create(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
            return Success();
        }

        public Service Delete(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return Success();
        }

        public IQueryable<StudentModel> Query()
        {
            return _db.Students.OrderBy(c => c.Name).Select(c => new StudentModel() { Record = c });
        }
        public Service Update(Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
            return Success();
        }

    }

}
