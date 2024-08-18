using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Dal.Abstract.Repositories;
using PersonnelManagement.Bll.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.Bll.Concrete
{
    public class PersonnelManager : IPersonnelService
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelManager(IPersonnelRepository personnelRepository) 
        {
            _personnelRepository = personnelRepository;
        }

        public void Create(Personnel entity)
        {
            _personnelRepository.Create(entity);
        }

        public void Delete(Personnel entity)
        {
            _personnelRepository.Delete(entity);
        }

        public Personnel GetEntity(Expression<Func<Personnel, bool>> filter)
        {
           return _personnelRepository.GetEntity(filter);
        }

        public IList<Personnel> List(Expression<Func<Personnel, bool>> filter)
        {
            return _personnelRepository.List(filter);
        }

        public void Update(Personnel entity)
        {
            _personnelRepository.Update(entity);
        }
    }
}
