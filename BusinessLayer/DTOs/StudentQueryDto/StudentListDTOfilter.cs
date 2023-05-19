using System.ComponentModel.DataAnnotations;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.DTOs.Request;


public enum StudentFilterBy
{
    [Display(Name = "All")]
    NoFilter = 0,
    [Display(Name = "By Votes...")]
    ByVotes,
 
}
public static class StudentListDTOfilter
{
    public static IQueryable<StudentDTO> FilterBooksBy(this IQueryable<StudentDTO> students, StudentFilterBy filterBy,
        string filterValue)
    {
        if (string.IsNullOrEmpty(filterValue)) return students;
        switch (filterBy)
        {
            case StudentFilterBy.NoFilter 
                : return students;
            default:
                throw new ArgumentOutOfRangeException(nameof(filterBy), filterBy, null);
        }
    }

}