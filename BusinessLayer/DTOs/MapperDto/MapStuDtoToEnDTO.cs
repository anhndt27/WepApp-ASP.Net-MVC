using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapStuDtoToEnDTO :Profile
{
    public MapStuDtoToEnDTO()
    {
        CreateMap<StudentDTO, EnrollmentDTO>()
            .ForMember(d => d.StudentName, src => src.MapFrom(m => m.Name))
            .ForMember(d => d.StudentCode, src => src.MapFrom(m => m.Code));
    }
}