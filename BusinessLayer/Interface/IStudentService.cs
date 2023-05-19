using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.BusinessLayer.Implement;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Interface
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDTO>> GetListSortAsync(SortFilterPageOptions options);
        Task<Student> GetByIdAsync(int? id);
        Task<IEnumerable<Student>> GetAllAsync();
        Task<bool> AddAsync(Student entity);
        Task<bool> UpdateAsync(Student entity);
        Task<bool> DeleteAsync(Student entity);
    }
}
