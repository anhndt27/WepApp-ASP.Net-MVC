using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;

namespace WebAppFinal.DataLayer.Implement
{
    public class EnrollmentRepo : Repository<Enrollment>, IEnrollmentRepo
    {
        public EnrollmentRepo(AppDbContext context) : base(context)
        {
        }

        
    }
}
