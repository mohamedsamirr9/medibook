using MediBook.API.DTOs;

namespace MediBook.API.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync();
        Task<IEnumerable<DoctorDto>> GetDoctorsBySpecialtyAsync(string specialty);
    }
}
