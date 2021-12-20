using Application.DTOs;
using Application.Services.Car;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CreateCar(CreateCarDTO car)
        {
            service.CreateCar(car);
            return Ok();
        }

        [HttpGet]
        public async Task<IEnumerable<GetCarDTO>> GetAllCars()
        {
            return await service.GetAllCars();
        }

        [HttpGet("{ID}")]
        public async Task<GetCarDTO> GetCarById(int id)
        {
            return await service.GetCarById(id);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarDTO car)
        {
            var UpdatedCar = await service.GetCarById(car.id);
            var newCar = mapper.Map<UpdateCarDTO>(UpdatedCar);
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
