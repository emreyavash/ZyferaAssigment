using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyferaAssigment.Entity.Concrete;

namespace ZyferaAssigment.Business.Abstract
{
    public interface IStudentService:IGenericService<Student>
    {
        public Student GetByStdNumber(string stdNumber);

    }
}
