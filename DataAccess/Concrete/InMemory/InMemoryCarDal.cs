using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {   // Veritabanından
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 11, ColorId = 333, DailyPrice = 300000, ModelYear = 2021, Description = "otomatik vites" },
                new Car { Id = 2, BrandId = 22, ColorId = 222, DailyPrice = 200000, ModelYear = 2019, Description = "düz vites" },
                new Car { Id = 3, BrandId = 33, ColorId = 111, DailyPrice = 150000, ModelYear = 2017, Description = "Kazalı,otomatik vites" },
            }; 

        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}
