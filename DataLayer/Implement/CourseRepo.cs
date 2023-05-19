using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;

namespace WebAppFinal.DataLayer.Implement
{
    public class CourseRepo : Repository<Course>, ICourseRepo
    {
        public CourseRepo(AppDbContext context) : base(context)
        {
           
        }
    }
}
