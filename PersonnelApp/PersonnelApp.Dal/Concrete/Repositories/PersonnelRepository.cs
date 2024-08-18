using PersonelApp.Model.Concrete.Base;
using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Dal.Abstract.Repositories;
using PersonnelApp.Dal.Concrete.BaseRepository;
using PersonnelApp.Dal.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Dal.Concrete.Repositories
{
    public class PersonnelRepository:Repository<Personnel,PersonnelManagementContext>,IPersonnelRepository
    {
    }
}
