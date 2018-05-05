using Repository.Pattern.Repositories;
using Service.Pattern;
using System.Collections.Generic;
using System.Linq;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public class TruckService : ITruckService
    {
        private IRepository<Truck> _repository;
        public TruckService(IRepository<Truck> repository)
        {
            _repository = repository;
        }

        public IList<Truck> GetAll()
        {
            return _repository.Queryable().ToList();
        }


        public void Add(Truck truck)
        {
            _repository.Insert(truck);
        }

        public void Update(Truck truck)
        {
            _repository.Update(truck);
        }
       
        public void Delete(Truck truck)
        {
            _repository.Delete(truck);
        }
    }
}
