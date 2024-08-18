using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PersonelApp.Model.Concrete.Entities;

namespace PersonnelManagement.Bll.Abstract
{
    public interface IPersonnelService
    {
        Personnel GetEntity(Expression<Func<Personnel, bool>> filter);
        IList<Personnel> List(Expression<Func<Personnel, bool>> filter);
        void Create(Personnel entity);
        void Update(Personnel entity);
        void Delete(Personnel entity);
    }
}
