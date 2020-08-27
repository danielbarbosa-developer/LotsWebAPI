using LotsWebAPI.Abstractions;
using LotsWebAPI.Infraestructure;
using LotsWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace LotsWebAPI.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly LotsDbContext context;

        public CarRepository(LotsDbContext ctx)
        {
            context = ctx;

        }
        public int Add(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return car.Id;
        }

        public Car Find(string plate)
        {
            return context.Cars.FirstOrDefault(u => u.Plate == plate);
        }

        public IEnumerable<Car> GetAll()
        {
            return context.Cars.ToList();
        }

        public void Remove(string plate)
        {
            var entity = context.Cars.First(u => u.Plate == plate);
            context.Cars.Remove(entity);
            context.SaveChanges();
        }

        public void Update(Car car)
        {
            
            context.Cars.Update(car);
            context.SaveChanges();

        }
    }
}
