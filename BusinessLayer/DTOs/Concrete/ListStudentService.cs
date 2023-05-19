using Microsoft.EntityFrameworkCore;
using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DTOs.Reponse;
using WebAppFinal.BusinessLayer.DTOs.StudentQueryDto;
using WebAppFinal.DataLayer.QueryObjects;

namespace WebAppFinal.BusinessLayer.DTOs.Concrete;

public class ListStudentService
{
    private readonly AppDbContext _context;

    public ListStudentService(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<StudentDTO> SortFilterPage(SortFilterPageOptions options)
    {
        var studentQuery = _context.Students
            .AsNoTracking()
            .MapStudentDTO()
            .OrderStudentBy(options.OrderByOptions)
            .FilterBooksBy(options.FilterBy,options.FilterValue);
        options.SetupRestOfDto(studentQuery);
        return studentQuery.Page(options.PageNum - 1, options.PageSize);
    }
}