using WebAppFinal.DTOs.Reponse;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;

public static class CourseListDTOSelect
{
    public static IQueryable<CourseDTO> MapCouresDTO(this IQueryable<Course> courses)
    {
        return courses.Select(c => new CourseDTO
        {
            ID = c.CourseID,
            Title = c.Title,
            Credits = c.Credits,
            Student = string.Join(",", c.Enrollments.Select(e => e.Student.Name))
        });
    } 
}