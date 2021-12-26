using Application.DTOs;
using Application.Services.Car;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Car;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService service;
        private readonly IMapper mapper;

        public CarController(ICarService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult CreateCar(CreateCarModel car)
        {
            var createdCar = mapper.Map<CreateCarDTO>(car);
            service.CreateCar(createdCar);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<GetCarModel>> GetAllCars()
        {
            var cars = await service.GetAllCars();
            var returnedCars = mapper.Map<IEnumerable<GetCarModel>>(cars);
            return returnedCars;
        }

        [HttpGet("{id}")]
        public async Task<GetCarModel> GetCarById(int id)
        {
            var car = await service.GetCarById(id);
            var returnedCar = mapper.Map<GetCarModel>(car);
            return returnedCar;
        }

        [HttpGet]
        [Route("/api/Car/brand/{brand}")]
        public async Task<IEnumerable<GetCarModel>> GetCarsByBrand(string brand)
        {
            var cars = await service.GetCarsByBrand(brand);
            var returnedCars = mapper.Map<IEnumerable<GetCarModel>>(cars);
            return returnedCars;
        }

        [HttpGet]
        [Route("/api/Car/Body/{body}")]
        public async Task<IEnumerable<GetCarModel>> GetCarsByBody(string body)
        {
            var cars = await service.GetCarsByBody(body);
            var returnedCars = mapper.Map<IEnumerable<GetCarModel>>(cars);
            return returnedCars;
        }

        [HttpGet]
        [Route("/api/Car/Mileage/{mileage}")]
        public async Task<IEnumerable<GetCarModel>> GetCarsByMileage(int mileage)
        {
            var cars = await service.GetCarsByMileage(mileage);
            var returnedCars = mapper.Map<IEnumerable<GetCarModel>>(cars);
            return returnedCars;
        }

        [HttpGet]
        [Route("/api/car/price/{price}")]
        public async Task<IEnumerable<GetCarModel>> GetCarsByPrice(int price)
        {
            var cars = await service.GetCarsByPrice(price);
            var returnedCars = mapper.Map<IEnumerable<GetCarModel>>(cars);
            return returnedCars;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarModel car)
        {
            var UpdatedCar = await service.GetCarById(car.id);
            var CarToBe = mapper.Map(car, UpdatedCar);
            var newCar = mapper.Map<UpdateCarDTO>(CarToBe);
            service.UpdateCar(newCar);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCar(int id)
        {
            service.DeleteCar(id);
            return Ok();
        }
    }
}
