using System.Collections.Generic;
using WebApplication4.Models;

namespace WebApplication4.Services.Interfaces
{
    public interface IRepository
    {
        void Create(Car car);

        void Edit(Car car);

        void Delete(Car car);

        Car Get(int id);
        
        IList<Car> GetAll();

        void Save();
	}
}