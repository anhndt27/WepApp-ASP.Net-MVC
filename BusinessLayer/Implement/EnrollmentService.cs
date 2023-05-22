using AutoMapper;
using WebAppFinal.BusinessLayer.DTOs.EnrollmentQueryDto;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.BusinessLayer.Implement
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly AppDbContext _context;
        public readonly IMapper _mapper;
        public readonly IStudentService _StudentService;

        public EnrollmentService(AppDbContext context, IMapper mapper,IStudentService studentService)
        {
            _context = context;
            _mapper = mapper;
            _StudentService = studentService;
        }

        /*public async Task<bool> AddStudentToCourse(int? CouresID, string? Code)
        {
            var res = await _context.Students.FindAsync(CouresID);
           
            throw new NotImplementedException();
        }*/

        public async Task<bool> AddStudentToCourse(int? CouresID, int? StudentID)
        {
            var entity = new Enrollment
            {
                StudentID = (int)StudentID,
                CourseID = (int)CouresID
            };
            var res = await _context.Enrollments.AddAsync(entity);
            await _context.SaveChangesAsync();
            if (res != null)
            {
                return true;
            }
            return false;
        }
    }
}
