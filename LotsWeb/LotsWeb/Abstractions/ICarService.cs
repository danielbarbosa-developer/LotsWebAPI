using LotsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsWebAPI.Abstractions
{
    public interface ICarService
    {
        public int Add(Car car);

        IEnumerable<Car> GetAll();

        Car Find(string plate);

        void Remove(string plate);

        void Update(Car car);
    }
}
