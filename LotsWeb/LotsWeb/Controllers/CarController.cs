using LotsWebAPI.Abstractions;
using LotsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsWebAPI.Controllers
{
    [Route("api/[Controller]")]
    public class CarController : ControllerBase
    {
       

        private readonly ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService ;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAll()
        {
            return Ok(carService.GetAll());
        }

        [HttpGet("{plate}")]
        public ActionResult GetByPlate(string plate)
        {
            var car = carService.Find(plate);
            if (car == null)
                return NotFound();

            return Ok(car);
        }
        [HttpPost]
       
        public ActionResult<int> AddNew (Car car) 
        {
           return carService.Add(car);
        }

        [HttpDelete]

        public void Remove(string plate)
        {
            carService.Remove(plate);
        }

        [HttpPut]

        public void Update (Car car)
        {
            carService.Update(car);
        }


    }
}
