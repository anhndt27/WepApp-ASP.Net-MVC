using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;

namespace WebAppFinal.DataLayer.Implement
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
