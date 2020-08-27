using LotsWebAPI.Abstractions;
using LotsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsWebAPI.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;
        public CarService(ICarRepository carRepo)
        {
            carRepository = carRepo;
        }

        public int Add(Car car)
        {
            carRepository.Add(car);
            return car.Id;
        }

        public Car Find(string plate)
        {
            return carRepository.Find(plate);
        }

        public IEnumerable<Car> GetAll()
        {
            return carRepository.GetAll();
        }

        public void Remove(string plate)
        {
            carRepository.Remove(plate);
        }

        public void Update(Car car)
        {
            carRepository.Update(car);
        }
    }
}
