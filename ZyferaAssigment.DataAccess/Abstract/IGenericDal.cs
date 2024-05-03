using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ZyferaAssigment.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class,new()
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter);
    }
}
