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
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,CategoryId=1,BrandId=1,ColorId=1,DailyPrice=100000,ModelYear=2015,Description="Araç İstanbul'da dır."},
                new Car{CarId=2,CategoryId=2,BrandId=2,ColorId=2,DailyPrice=500000,ModelYear=2020,Description="Araç Ankara'da dır."},
                new Car{CarId=3,CategoryId=2,BrandId=2,ColorId=3,DailyPrice=90000,ModelYear=2014,Description="Araç İzmir'da dır."},
                new Car{CarId=4,CategoryId=1,BrandId=1,ColorId=4,DailyPrice=250000,ModelYear=2019,Description="Araç Bursa'da dır."},
                new Car{CarId=5,CategoryId=1,BrandId=1,ColorId=5,DailyPrice=150000,ModelYear=2018,Description="Araç Antalya'da dır."}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public List<Car> GeyAllByCategory(int categoryId)
        {
            return _cars.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.Description = car.Description;
        }
    }
}
