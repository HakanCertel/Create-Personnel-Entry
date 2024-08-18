using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Dal.Abstract.Repositories;
using PersonnelApp.Dal.Concrete.BaseRepository;
using PersonnelApp.Dal.Concrete.Context;
using PersonnelApp.Model.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Concrete.Repositories
{
    public class MaterialRepository : Repository<Materials, PersonnelManagementContext>, IMaterialRepository
    {
    }
}
