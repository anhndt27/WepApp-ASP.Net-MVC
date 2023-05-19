using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.Interface
{
    public interface IEnrollmentService
    {
        Task<bool> AddStudentToCourse(EnrollmentDTO entity);
        //Task<IEnumerable<Enrollment>> GetAllAsync();
        //Task<bool> AddAsync(Enrollment entity);
        //Task<bool> DeleteAsync(Enrollment entity);
    }
}
