using MediBook.API.DTOs;
using MediBook.API.Mapping;
using MediBook.API.Repositories;

namespace MediBook.API.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public async Task<IEnumerable<DoctorDto>> GetAllDoctorsAsync()
        {
            var doctors = await _doctorRepository.GetAllAsync();
            return doctors.Select(d => d.ToDto());
        }

        public async Task<IEnumerable<DoctorDto>> GetDoctorsBySpecialtyAsync(string specialty)
        {
            var doctors = await _doctorRepository.GetBySpecialtyAsync(specialty);
            return doctors.Select(d => d.ToDto());
        }
    }
}
