namespace MediBook.API.DTOs
{
    public class AppointmentResponseDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string DoctorName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public DateTime AppointmentDate { get; set; }
        public int QueueNumber { get; set; }
        public int EstimatedWaitMinutes { get; set; }
    }
}
