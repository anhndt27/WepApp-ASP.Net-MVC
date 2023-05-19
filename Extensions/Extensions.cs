using WebAppFinal.BusinessLayer.Implement;
using WebAppFinal.BusinessLayer.Interface;
using WebAppFinal.DataLayer.Implement;
using WebAppFinal.DataLayer.Interface;

namespace WebAppFinal.Extentions
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //DI Service
            services.AddTransient<IStudentService, StudentService>();
            //services.AddTransient<IEnrollmentService, EnrollmentService>();
            services.AddTransient<ICourseServices, CourseService>();


            ////DI Repository
            ///
            services.AddTransient<IStudentRepository,StudentRepository>();
            services.AddTransient<IStudentRepo, StudentRepo>();
            services.AddTransient<ICourseRepo, CourseRepo>();
            return services;
        }
    }
}
