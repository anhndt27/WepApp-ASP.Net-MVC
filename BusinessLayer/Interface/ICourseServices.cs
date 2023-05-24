using System.Collections;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Interface
{
    public interface ICourseServices
    {
        Task<IEnumerable<CourseDTO>> GetListCourseStudentAsync();
        Task<IEnumerable<CourseDTO>> GetByIdAsync(int? id);
        Task<bool> AddAsync(CourseRequestDto entity);
        Task<bool> UpdateAsync(CourseRequestDto entity);
        Task<CourseRequestDto> FindById(int? id);
        Task<bool> DeleteAsync(CourseRequestDto entity);
    }
}