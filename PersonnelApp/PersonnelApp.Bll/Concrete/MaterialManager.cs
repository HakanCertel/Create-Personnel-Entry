using PersonelApp.Model.Concrete.Entities;
using PersonnelApp.Bll.Abstract;
using PersonnelApp.Dal.Abstract.Repositories;
using PersonnelApp.Model.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Bll.Concrete
{
    public class MaterialManager:IMaterialService
    {
        private readonly IMaterialRepository _materailRepository;
        public MaterialManager(IMaterialRepository materailRepository)
        {
            _materailRepository = materailRepository;
        }

        public void Create(Materials entity)
        {
            _materailRepository.Create(entity);
        }

        public void Delete(Materials entity)
        {
            _materailRepository.Delete(entity);
        }

        public Materials GetEntity(Expression<Func<Materials, bool>> filter)
        {
            return _materailRepository.GetEntity(filter);
        }

        public IList<Materials> List(Expression<Func<Materials, bool>> filter)
        {
            return _materailRepository.List(filter);
        }

        public void Update(Materials entity)
        {
            _materailRepository.Update(entity);
        }
    }
}
