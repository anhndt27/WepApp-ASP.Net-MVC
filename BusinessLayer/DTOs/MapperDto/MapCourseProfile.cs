using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapCourseProfile : Profile
{
    public MapCourseProfile()
    {
        CreateMap<CourseRequestDto, Course>()
            .ForMember(d => d.CourseID, source => source.MapFrom(m => m.ID))
            .ForMember(d => d.Title, source => source.MapFrom(m => m.Title))
            .ForMember(d => d.Credits, source => source.MapFrom(m => m.Credits))
            .ForMember(d => d.Enrollments, source => source.MapFrom(m => m.Enrollments));
    }
}