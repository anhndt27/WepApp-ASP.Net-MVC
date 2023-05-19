using WebAppFinal.BusinessLayer.DTOs.Concrete;
using WebAppFinal.BusinessLayer.DTOs.Request;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.BusinessLayer.Implement
{
    public class StudentService : IStudentService
    {
        public readonly IStudentRepository _studentRepository;
        private readonly AppDbContext _context;

        public StudentService(IStudentRepository studentRepository, AppDbContext context)
        {
            _studentRepository = studentRepository;
            _context = context;
        }

        public async Task<bool> AddAsync(Student entity)
        {
            var res = await _studentRepository.AddAsync(entity);
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

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }


        public async Task<IEnumerable<StudentDTO>> GetListSortAsync(SortFilterPageOptions options)
        {
            var listService = new ListStudentService(_context);
            var listStudent = listService.SortFilterPage(options).ToList();
            return listStudent.ToList();
        }

        public Task<Student> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
