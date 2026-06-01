using MediBook.API.DTOs;

namespace MediBook.API.Services
{
    public interface IAppointmentService
    {
        Task<AppointmentResponseDto> CreateAppointmentAsync(CreateAppointmentDto dto);
        Task<IEnumerable<AppointmentResponseDto>> GetAllAppointmentsAsync();
    }
}
