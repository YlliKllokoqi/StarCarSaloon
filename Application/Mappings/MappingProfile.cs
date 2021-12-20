using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Car, GetCarDTO>().ReverseMap();
            CreateMap<Car, CreateCarDTO>().ReverseMap();
            CreateMap<Car, UpdateCarDTO>().ReverseMap();
            CreateMap<GetCarDTO, UpdateCarDTO>().ReverseMap();
        }

        
    }
}
