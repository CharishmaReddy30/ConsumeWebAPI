using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAustralia.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using EnergyAustralia.Models;

namespace EnergyAustralia.Controllers
{
    public class CarShowController : Controller
    {
        private ICarShowService _carShowService;

        public CarShowController(ICarShowService carShowService)
        {
            _carShowService = carShowService;
        }

        public IActionResult Index()
        {
            var carShows = _carShowService.GetCarShows();
            List<CarViewModel> carShowsList = new List<CarViewModel>();
            foreach (var car in carShows.Result)
            {
                foreach(var item in car.Cars)
                {
                    var newCar = new CarViewModel
                    {
                        Name = car.Name,
                        Make = item.Make,
                        Model = item.Model
                    };
                    carShowsList.Add(newCar);

                }
            }
            var cars = carShowsList.OrderBy(c => c.Make).GroupBy(x => x.Make).ToList();
            return View(cars);
        }
    }
}