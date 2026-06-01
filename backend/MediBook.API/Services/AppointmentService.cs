using MediBook.API.DTOs;
using MediBook.API.Mapping;
using MediBook.API.Repositories;

namespace MediBook.API.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }
        public async Task<AppointmentResponseDto> CreateAppointmentAsync(CreateAppointmentDto dto)
        {
            var appointment = dto.ToEntity();
            var queueNumber = await _appointmentRepository
            .GetQueueNumberAsync(dto.DoctorId, dto.AppointmentDate);
            appointment.QueueNumber = queueNumber + 1;

            _appointmentRepository.Create(appointment);
            await _appointmentRepository.SaveAsync();

            var saved = await _appointmentRepository.GetByIdAsync(appointment.Id);
            return saved!.ToDto();
        }

        public async Task<IEnumerable<AppointmentResponseDto>> GetAllAppointmentsAsync()
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return appointments.Select(a => a.ToDto());
        }
    }
}
