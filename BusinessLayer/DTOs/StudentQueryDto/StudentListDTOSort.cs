using System.ComponentModel.DataAnnotations;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.Request;
public enum OrderByOptions
{
    [Display(Name = "sort by...")] SimpleOrder = 0,
    [Display(Name = "Votes ↑")] ByVotes,
    
    
    
}
public static class StudentListDTOSort
{
    public static IQueryable<StudentDTO> OrderStudentBy(this IQueryable<StudentDTO> _students, OrderByOptions options)
    {
        switch (options)
        {
            case OrderByOptions.SimpleOrder:
                return _students.OrderByDescending(x => x.ID);
            default:
                throw new ArgumentOutOfRangeException(
                    nameof(options), options, null);
        }
    }
}