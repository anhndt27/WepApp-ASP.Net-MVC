using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.DTOs.MapperDto;

public class MapEnrollmentDTO : Profile
{
    public MapEnrollmentDTO()
    {
        CreateMap<Enrollment, EnrollmentDTO>()
            .ForMember(d => d.Grade, source => source.MapFrom(m => m.Order))
            .ForMember(d => d.CourseTitle, sorce => sorce.MapFrom(e => e.Course));
    }
}