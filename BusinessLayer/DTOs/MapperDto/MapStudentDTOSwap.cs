using AutoMapper;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapStudentDTOSwap : Profile
{
    public MapStudentDTOSwap()
    {
        CreateMap<StudentDTO, Student>()
            .ForMember(d=> d.ID,src => src.MapFrom(s => s.ID))
            .ForMember(d => d.Name, src => src.MapFrom(s => s.Name))
            .ForMember(d => d.Code, src => src.MapFrom(s => s.Code));
    }
    
}