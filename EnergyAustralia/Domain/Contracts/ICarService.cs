using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAustralia.Models;

namespace EnergyAustralia.Domain.Contracts
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
    }
}
