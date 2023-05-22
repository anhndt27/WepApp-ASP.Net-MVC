using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapCourseDtoToEnDto : Profile
{
    public MapCourseDtoToEnDto()
    {
        CreateMap<CourseDTO, EnrollmentDTO>()
            .ForMember(d => d.CourseTitle, src => src.MapFrom(m => m.Title))
            .ForMember(d => d.CourseCredit, src => src.MapFrom(m => m.Credits));
    }
   
}