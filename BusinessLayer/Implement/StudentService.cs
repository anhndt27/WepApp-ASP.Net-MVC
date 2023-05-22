using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAppFinal.BusinessLayer.DTOs.Concrete;
using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;

using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Implement
{
    public class StudentService : IStudentService
    {
        
        private readonly AppDbContext _context;
        public readonly IMapper _mapper;

        public StudentService( AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(Student entity)
        {
            var res = await _context.AddAsync(entity);
            if (res != null)
            {
                return true;
            }
            return false;
        }

        public Task<bool> DeleteAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task<StudentDTO> FindByCode(string code)
        {
            var res =  _context.Students.FirstOrDefaultAsync(s => s.Code == "CT0201");
            return _mapper.Map<StudentDTO>(res);
        }

        public async Task<IEnumerable<StudentDTO>> Findddd(int id)
        {
            var res =  _context.Students.AsNoTracking();
            return _mapper.Map<IEnumerable<StudentDTO>>(res.Where(s => s.ID == id));
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
           
            return await _context.Students.ToListAsync();
            
        }

        public List<Student> GetListAsync()
        {
            return _context.Students.ToList();
        }

        public async Task<IEnumerable<StudentDTO>> GetListSortAsync(SortFilterPageOptions options)
        {
            var listService = new ListStudentService(_context);
            var listStudent = await listService.SortFilterPage(options).ToListAsync();
            return listStudent.ToList();
        }

        public Task<IEnumerable<StudentDTO>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDTO> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
