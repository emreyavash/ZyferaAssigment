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
    public class GradeService : IGradeService
    {
        private readonly IGradeDal _gradeDal;
        public void Add(Grade entity)
        {
            _gradeDal.Add(entity);
        }

        public List<Grade> GetAll()
        {
            var result = _gradeDal.GetAll();
            return result;
        }
    }
}
