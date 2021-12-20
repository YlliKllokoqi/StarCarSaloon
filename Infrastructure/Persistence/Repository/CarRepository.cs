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

        public void UpdateCar(Car car)
        {
            dbContext.Cars.Update(car);
            dbContext.SaveChanges();
        }
    }
}
