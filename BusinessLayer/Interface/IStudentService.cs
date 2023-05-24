using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.BusinessLayer.Implement;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Interface
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDTO>> GetListSortAsync(SortFilterPageOptions options);
        Task<StudentDTO> GetByIdAsync(int? id);
        Task<bool> AddAsync(StudentDTO entity);

        Task<bool> UpdateAsync(StudentDTO entity);

        Task<bool> DeleteAsync(StudentDTO entity);
        Task<StudentDTO> FindByCode(string code);
        Task<IEnumerable<StudentDTO>> Findddd(int id);
    }
}