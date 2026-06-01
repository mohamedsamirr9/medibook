using MediBook.API.Data;
using MediBook.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediBook.API.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context) {
            _context = context;
        }
        public Appointment Create(Appointment entity)
        {
            _context.Appointments.Add(entity);
            return entity;

        }

        public async Task DeleteAsync(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment != null)
                _context.Appointments.Remove(appointment);
        }

        public async Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await _context.Appointments
                .Include(a => a.Doctor)
                .ToListAsync();
        }

        public async Task<Appointment?> GetByIdAsync(int id)
        {
            return await _context.Appointments
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public  async Task<int> GetQueueNumberAsync(int doctorId, DateTime date)
        {
            return await _context.Appointments
                .CountAsync(a => a.DoctorId == doctorId
                            && a.AppointmentDate.Date == date.Date);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(Appointment entity)
        {
             _context.Appointments.Update(entity);
        }
    }
}
