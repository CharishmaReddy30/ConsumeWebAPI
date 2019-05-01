using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAustralia.Models;

namespace EnergyAustralia.Models
{
    public class CarShow
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
