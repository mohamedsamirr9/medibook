using MediBook.API.DTOs;
using MediBook.API.Models;

namespace MediBook.API.Mapping
{
    public static class DoctorMappings
    {
        public static DoctorDto ToDto(this Doctor doctor)
        {
            return new DoctorDto
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Specialty = doctor.Specialty,
                ImageUrl = doctor.ImageUrl
            };
        }
    }
}