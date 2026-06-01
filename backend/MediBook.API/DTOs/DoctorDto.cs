namespace MediBook.API.DTOs
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
    }
}
