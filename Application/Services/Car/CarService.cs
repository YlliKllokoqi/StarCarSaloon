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

        public void UpdateCar(UpdateCarDTO carDTO)
        {
            var UpdatedCar = mapper.Map<Domain.Entities.Car>(carDTO);
            repository.UpdateCar(UpdatedCar);
        }
    }
}
