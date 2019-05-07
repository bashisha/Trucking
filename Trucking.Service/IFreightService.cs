using System.Collections.Generic;
using Trucking.Entities.Models;

namespace Trucking.Service
{
    public interface IFreightService
    {
        IList<Freight> GetAll();
        void Add(Freight freight);
        void Update(Freight freight);
        void Delete(Freight freight);
    }
}
