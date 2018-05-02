using Repository.Pattern.Repositories;
using System.Collections.Generic;
using System.Linq;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public class TruckService : ITruckService
    {
        private readonly IRepository<Truck> _repository;
        public TruckService(IRepository<Truck> repository)
        {
            _repository = repository;
        }

        public IList<Truck> GetAllTrucks()
        {
            return _repository.Queryable().ToList();
        }


    }
}
