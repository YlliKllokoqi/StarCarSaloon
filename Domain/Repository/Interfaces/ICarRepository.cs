using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetCarById(int id);
        Task<IEnumerable<Car>> GetCarsByBrand(string brand);
        Task<IEnumerable<Car>> GetCarsByBody(string body);
        Task<IEnumerable<Car>> GetCarsByPrice(int price);
        Task<IEnumerable<Car>> GetCarsByMileage(int mileage);
        void CreateCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
