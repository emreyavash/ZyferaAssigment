using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZyferaAssigment.DataAccess.Abstract;

namespace ZyferaAssigment.DataAccess.EFRepository
{
    public class EFGenericDal<TEntity, TContext> : IGenericDal<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EFGenericDal(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var added = _context.Add(entity);
            added.State = EntityState.Added;
            _context.SaveChanges();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return filter == null ? _context.Set<TEntity>().ToList():_context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
