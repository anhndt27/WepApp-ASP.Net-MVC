using WebAppFinal.DataLayer.Entities;

namespace WebAppFinal.DataLayer.Interface
{
    public interface IStudentRepo : IDisposable
    {
        Task<Student> Details(int? id);
        Task<IEnumerable<Student>> GetAll();
        Task<bool> Edit(Student entity);
        Task Delete(int? id);
        Task<bool> Create(Student entity);
    }
}
