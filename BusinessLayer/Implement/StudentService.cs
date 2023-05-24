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

        public StudentService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(StudentDTO entity)
        {
            var students = _mapper.Map<Student>(entity);
            var res = _context.Add(students);
            await _context.SaveChangesAsync();
            if (res != null) return true;
            return false;
        }

        public async Task<bool> DeleteAsync(StudentDTO entity)
        {
            var students = _mapper.Map<Student>(entity);
            var res = _context.Students.Remove(students);
            await _context.SaveChangesAsync();
            if (res != null) return true;
            return false;
        }

        public async Task<StudentDTO> FindByCode(string code)
        {
            var res = _context.Students.FirstOrDefaultAsync(s => s.Code == "CT0201");
            return _mapper.Map<StudentDTO>(res);
        }

        public async Task<IEnumerable<StudentDTO>> Findddd(int id)
        {
            var res = _context.Students.AsNoTracking();
            return _mapper.Map<IEnumerable<StudentDTO>>(res.Where(s => s.ID == id));
        }

        public async Task<IEnumerable<StudentDTO>> GetListSortAsync(SortFilterPageOptions options)
        {
            var listService = new ListStudentService(_context);
            var listStudent = await listService.SortFilterPage(options).ToListAsync();
            return listStudent.ToList();
        }

        public async Task<StudentDTO> GetByIdAsync(int? id)
        {
            var res = await _context.Students.FindAsync(id);
            return _mapper.Map<StudentDTO>(res);
        }

        public async Task<bool> UpdateAsync(StudentDTO entity)
        {
            var students = _mapper.Map<Student>(entity);
            var res = _context.Students.Update(students);
            await _context.SaveChangesAsync();
            if (res != null) return true;
            else
            {
                return false;
            }
        }
    }
}