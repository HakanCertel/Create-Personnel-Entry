using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Abstract.BaseRepository
{
    public interface IBaseRepository<T>
    {
        T GetEntity(Expression<Func<T,bool>> filter);
        List<T> List(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
