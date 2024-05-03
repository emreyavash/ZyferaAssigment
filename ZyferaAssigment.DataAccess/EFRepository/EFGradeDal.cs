using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZyferaAssigment.DataAccess.Abstract;
using ZyferaAssigment.DataAccess.Context;
using ZyferaAssigment.Entity.Concrete;

namespace ZyferaAssigment.DataAccess.EFRepository
{
    public class EFGradeDal : EFGenericDal<Grade, ZyferaDbContext>, IGradeDal
    {
        public EFGradeDal(ZyferaDbContext context) : base(context)
        {
        }
    }
}
