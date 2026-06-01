namespace MediBook.API.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public string? Notes { get; set; }
        public int QueueNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
