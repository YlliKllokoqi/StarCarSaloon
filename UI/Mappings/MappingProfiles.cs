using Application.DTOs;
using AutoMapper;
using Model.Car;

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
        }
    }
}
