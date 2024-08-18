using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Dal.Abstract.BaseRepository;
using PersonnelApp.Model.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Abstract.Repositories
{
    public interface IMaterialRepository : IBaseRepository<Materials>
    {
    }
}
