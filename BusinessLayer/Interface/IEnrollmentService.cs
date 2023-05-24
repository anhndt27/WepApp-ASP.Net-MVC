using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.Interface
{
    public interface IEnrollmentService
    {
        Task<bool> AddStudentToCourse(int? CouresID, int? StudentID);
        
      
    }
}
