using Domain.Entities;
using Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repository
{
    public class CarRepository : ICarRepository
    {
        public AppDbContext dbContext;
        public CarRepository(AppDbContext db)
        {
            dbContext = db;
        }

        public void CreateCar(Car car)
        {
            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var car = dbContext.Cars.FirstOrDefault(x => x.id == id);
            dbContext.Cars.Remove(car);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await dbContext.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int id)
        {
            return await dbContext.Cars.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<IEnumerable<Car>> GetCarsByBody(string body)
        {
            var cars = dbContext.Cars.Where(x => x.Body == body);
            return await cars.ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetCarsByBrand(string brand)
        {
            var cars = dbContext.Cars.Where(x => x.Brand == brand);
            return await cars.ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetCarsByMileage(int mileage)
        {
            var cars = dbContext.Cars.Where(x => x.Mileage <= mileage);
            return await cars.ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetCarsByPrice(int price)
        {
            var cars = dbContext.Cars.Where(x => x.Price <= price);
            return await cars.ToListAsync();
        }

        public void UpdateCar(Car car)
        {
            dbContext.ChangeTracker.Clear();
            dbContext.Cars.Update(car);
            dbContext.SaveChanges();
        }
    }
}
