using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyferaAssigment.Business.Abstract
{
    public interface IGenericService< T> where T : class,new()
    {
        void Add(T entity);
        List<T> GetAll();
    }
}
