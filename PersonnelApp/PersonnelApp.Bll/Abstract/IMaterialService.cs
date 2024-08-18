using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Model.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Bll.Abstract
{
    public interface IMaterialService
    {
        Materials GetEntity(Expression<Func<Materials, bool>> filter);
        IList<Materials> List(Expression<Func<Materials, bool>> filter);
        void Create(Materials entity);
        void Update(Materials entity);
        void Delete(Materials entity);
    }
}
