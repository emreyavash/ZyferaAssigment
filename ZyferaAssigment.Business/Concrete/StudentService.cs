using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyferaAssigment.Business.Abstract;
using ZyferaAssigment.DataAccess.Abstract;
using ZyferaAssigment.Entity.Concrete;

namespace ZyferaAssigment.Business.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentService(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student entity)
        {
           _studentDal.Add(entity);
        }

        public List<Student> GetAll()
        {
            var result = _studentDal.GetAll();
            return result;
        }

        public Student GetByStdNumber(string stdNumber)
        {
            var result = _studentDal.Get(x => x.StdNumber == stdNumber);
            return result;
        }
    }
}
