using WebAppFinal.DataLayer.Context;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.BusinessLogic;

public class ListCourseService
{
    private readonly AppDbContext _context;

    public ListCourseService(AppDbContext context)
    {
        _context = context;
    }
    
    //public IQueryable<CourseDTO> MapCouresDTO
}