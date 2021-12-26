using Application.DTOs;
using AutoMapper;
using Domain.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Car
{
    public class CarService : ICarService
    {
        public readonly ICarRepository repository;
        public readonly IMapper mapper;

        public CarService(ICarRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public void CreateCar(CreateCarDTO carDTO)
        {
            var CreatedCar = mapper.Map<Domain.Entities.Car>(carDTO);
            repository.CreateCar(CreatedCar);
        }

        public void DeleteCar(int id)
        {
            repository.DeleteCar(id);
        }

        public async Task<IEnumerable<GetCarDTO>> GetAllCars()
        {
            var cars = await repository.GetAllCars();
            return mapper.Map<IEnumerable<GetCarDTO>>(cars);
        }

        public async Task<GetCarDTO> GetCarById(int id)
        {
            var car = await repository.GetCarById(id);
            return mapper.Map<GetCarDTO>(car);
        }

        public async Task<IEnumerable<GetCarDTO>> GetCarsByBody(string body)
        {
            var cars = await repository.GetCarsByBody(body);
            return mapper.Map<IEnumerable<GetCarDTO>>(cars);
        }

        public async Task<IEnumerable<GetCarDTO>> GetCarsByBrand(string brand)
        {
            var cars = await repository.GetCarsByBrand(brand);
            return mapper.Map<IEnumerable<GetCarDTO>>(cars);
        }

        public async Task<IEnumerable<GetCarDTO>> GetCarsByMileage(int mileage)
        {
            var cars = await repository.GetCarsByMileage(mileage);
            return mapper.Map<IEnumerable<GetCarDTO>>(cars);
        }

        public async Task<IEnumerable<GetCarDTO>> GetCarsByPrice(int price)
        {
            var cars = await repository.GetCarsByPrice(price);
            return mapper.Map<IEnumerable<GetCarDTO>>(cars);
        }

        public void UpdateCar(UpdateCarDTO carDTO)
        {
            var UpdatedCar = mapper.Map<Domain.Entities.Car>(carDTO);
            repository.UpdateCar(UpdatedCar);
        }
    }
}
