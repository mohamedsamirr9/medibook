using MediBook.API.Models;

namespace MediBook.API.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<int> GetQueueNumberAsync(int doctorId, DateTime date);
        
    }
}
