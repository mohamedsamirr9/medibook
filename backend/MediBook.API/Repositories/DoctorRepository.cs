using MediBook.API.Data;
using MediBook.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediBook.API.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorRepository(AppDbContext context) {
            _context = context;
        }
        public Doctor Create(Doctor entity)
        {
            _context.Doctors.Add(entity);
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
            }
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor?> GetByIdAsync(int id)
        {
            return await _context.Doctors.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Doctor>> GetBySpecialtyAsync(string specialty)
        {
            return await _context.Doctors.Where(d => d.Specialty == specialty).ToListAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(Doctor entity)
        {
            _context.Update(entity);
        }
    }
}
