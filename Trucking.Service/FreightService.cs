using Repository.Pattern.Repositories;
using System.Collections.Generic;
using System.Linq;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public class FreightService : IFreightService
    {
        private IRepository<Freight> _repository;
        public FreightService(IRepository<Freight> repository)
        {
            _repository = repository;
        }

        public IList<Freight> GetAll()
        {
            return _repository.Queryable().ToList();
        }


        public void Add(Freight freight)
        {
            _repository.Insert(freight);
        }

        public void Update(Freight freight)
        {
            _repository.Update(freight);
        }
       
        public void Delete(Freight freight)
        {
            _repository.Delete(freight);
        }
    }
}
