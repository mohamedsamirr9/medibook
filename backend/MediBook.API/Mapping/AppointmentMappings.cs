using MediBook.API.DTOs;
using MediBook.API.Models;

namespace MediBook.API.Mapping
{
    public static class AppointmentMappings
    {
        public static AppointmentResponseDto ToDto(this Appointment appointment, int queueNumber)
        {
            return new AppointmentResponseDto
            {
                Id = appointment.Id,
                FullName = appointment.FullName,
                DoctorName = appointment.Doctor?.Name ?? "Not Found",
                Specialty = appointment.Doctor?.Specialty ?? "Not Found",
                AppointmentDate = appointment.AppointmentDate,
                QueueNumber = appointment.QueueNumber,
                EstimatedWaitMinutes = (queueNumber - 1) * 15
            };
        }
        public static Appointment ToEntity(this CreateAppointmentDto dto)
        {
            return new Appointment
            {
                FullName = dto.FullName,
                Phone = dto.Phone,
                Email = dto.Email,
                DoctorId = dto.DoctorId,
                AppointmentDate = dto.AppointmentDate,
                Notes = dto.Notes
            };
        }
    }
}
