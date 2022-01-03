using Application.DTOs;
using Application.DTOs.Identity;
using AutoMapper;
using Model.Car;
using Model.Identity;

namespace UI.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<GetCarDTO, GetCarModel>().ReverseMap();
            CreateMap<CreateCarDTO, CreateCarModel>().ReverseMap();
            CreateMap<UpdateCarDTO, UpdateCarModel>().ReverseMap();
            CreateMap<GetCarModel, UpdateCarModel>().ReverseMap();
            CreateMap<GetCarDTO, UpdateCarModel>().ReverseMap();

            CreateMap<LoginDTO, LoginModel>().ReverseMap();
            CreateMap<RegisterDTO, RegisterModel>().ReverseMap();
        }
    }
}
