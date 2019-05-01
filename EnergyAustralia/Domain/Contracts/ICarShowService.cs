using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAustralia.Models;

namespace EnergyAustralia.Domain.Contracts
{
    public interface ICarShowService
    {
        Task<IEnumerable<CarShow>> GetCarShows();
    }
}
