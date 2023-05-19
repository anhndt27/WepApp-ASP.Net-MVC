using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAppFinal.BusinessLayer.BusinessLogic;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.BusinessLayer.DTOs.StudentQueryDto;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Implement
{
    public class CourseService : ICourseServices
    {
        public readonly ICourseRepo _courseRepo;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        
        public CourseService(ICourseRepo courseRepo, AppDbContext context, IMapper mapper)
        {
            _context = context;
            _courseRepo = courseRepo;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(CourseRequestDto entity)
        {
            var course = _mapper.Map<Course>(entity);
            var res =  _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            if (res != null)
            {
                return true;
            }
            return false;
        }
        
        public Task<IEnumerable<CourseDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// Get All Course and student
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<CourseDTO>> GetListCourseStudentAsync()
        {
            var res =  _context.Courses.AsNoTracking().MapCouresDTO();
            return res.ToList();
        }

        public async Task<IEnumerable<CourseDTO>> GetByIdAsync(int? id)
        {
            var res = _context.Courses.AsNoTracking().MapCouresDTO();
               
            /*.Where(e => e.ID == id);*/
            return res.Where(e => e.ID == id);
        }

        public async Task<bool> UpdateAsync(CourseRequestDto entity)
        {
            var course = _mapper.Map<Course>(entity);
            var res =  _context.Courses.Update(course);
            await _context.SaveChangesAsync();
            if (res != null)
            {
                return true;
            }
            return false;
        }

        public async Task<CourseRequestDto> FindById(int? id)
        {
            var res = await _context.Courses.FindAsync(id);
            return _mapper.Map<CourseRequestDto>(res);
        }

        public Task<bool> DeleteAsync(CourseRequestDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
