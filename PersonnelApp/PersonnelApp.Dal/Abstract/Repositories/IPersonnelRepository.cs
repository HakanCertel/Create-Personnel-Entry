using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Dal.Abstract.BaseRepository;

namespace PersonnelApp.Dal.Abstract.Repositories
{
    public interface IPersonnelRepository : IBaseRepository<Personnel>
    {
    }
}
