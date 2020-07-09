using System.Collections.Generic;
using System.Linq;
using WebApplication4.Data;
using WebApplication4.Models;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.Services.Implementations
{
    public class Repository : IRepository
    {
        private readonly CarsContext _context;

        public Repository(CarsContext context)
        {
            _context = context;
        }

        public void Create(Car car)
        {
            _context.Cars.Add(car);
        }

        public void Edit(Car car)
        {
            var car1 = _context.Cars.Find(car.Id);
            car1.Title = car.Title;
            car1.Kuzov = car.Kuzov;
            car1.Color = car.Color;
            car1.Power = car.Power;
            _context.SaveChanges();
        }

        public void Delete(Car car)
        {
            _context.Cars.Remove(car);
        }

        public Car Get(int id)
        {
            return _context.Cars.First(x => x.Id == id);
        }

        public IList<Car> GetAll()
        {
            return _context.Cars.ToList();
        }

		public object Get(int? id)
		{
            return _context.Cars.First(x => x.Id == id);
        }

		public void Save()
		{
            _context.SaveChanges();
		}
	}
}