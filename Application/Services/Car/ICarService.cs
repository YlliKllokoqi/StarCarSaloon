using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Car
{
    public interface ICarService
    {
        Task<IEnumerable<GetCarDTO>> GetAllCars();
        Task<GetCarDTO> GetCarById(int id);
        void CreateCar(CreateCarDTO carDTO);
        void UpdateCar(UpdateCarDTO carDTO);
        void DeleteCar(int id);
    }
}
