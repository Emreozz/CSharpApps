using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface EfEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);

        public List<T> GetAll(Expression<Func<T, bool>> filter = null);

        public void Add(T entity);

        public void Update(T entity);

        public void Delete(T entity);
    }
}
