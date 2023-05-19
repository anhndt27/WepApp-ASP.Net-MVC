using Microsoft.EntityFrameworkCore;
using WebAppFinal.DataLayer.Context;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DataLayer.Interface;

namespace WebAppFinal.DataLayer.Implement
{
    public class StudentRepo : IStudentRepo
    {
        public AppDbContext _context;
        public StudentRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Student entity)
        {

            var res = _context.Students.Add(entity);
            await _context.SaveChangesAsync();
            if (res != null)
            {
                return true;
            }
            return false;
        }

        public async Task Delete(int? id)
        {
            var userProfile = await _context.Students.FindAsync(id);

            if (userProfile != null)
            {
                _context.Students.Remove(userProfile);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<Student> Details(int? id)
        {
            return await _context.Students.FindAsync(id);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<bool> Edit(Student entity)
        {
            var res = _context.Students.Update(entity);
            await _context.SaveChangesAsync();

            if (res != null)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
