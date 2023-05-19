using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapReturnCourse : Profile
{
    public MapReturnCourse()
    {
        CreateMap<Course, CourseRequestDto>()
            .ForMember(d => d.ID, source => source.MapFrom(m => m.CourseID))
            .ForMember(d => d.Title, source => source.MapFrom(m => m.Title))
            .ForMember(d => d.Credits, source => source.MapFrom(m => m.Credits))
            .ForMember(d => d.Enrollments, source => source.MapFrom(m => m.Enrollments));
    }
}