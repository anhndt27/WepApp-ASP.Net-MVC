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
        Task<IEnumerable<Student>> GetAllAsync();
        List<Student> GetListAsync();
        Task<bool> AddAsync(Student entity);
        Task<bool> UpdateAsync(Student entity);
        //Task<bool> DeleteAsync(Student entity);
        Task<StudentDTO> FindByCode(string code);
        Task<IEnumerable<StudentDTO>> Findddd(int id);
    }
}
