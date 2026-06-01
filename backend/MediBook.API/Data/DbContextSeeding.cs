using MediBook.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediBook.API.Data
{
    public static class DbContextSeeding
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                // Cardiology
                new Doctor { Id = 1, Name = "Dr. Ahmed Ali", Specialty = "Cardiology", ImageUrl = "https://images.unsplash.com/photo-1622253692010-333f2da6031d?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 2, Name = "Dr. Sara Mohamed", Specialty = "Cardiology", ImageUrl = "https://images.unsplash.com/photo-1594824813573-246434e33963?q=80&w=200&auto=format&fit=crop" },

                // Dermatology
                new Doctor { Id = 3, Name = "Dr. Mohamed Hassan", Specialty = "Dermatology", ImageUrl = "https://images.unsplash.com/photo-1537368910025-700350fe46c7?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 4, Name = "Dr. Nour Ahmed", Specialty = "Dermatology", ImageUrl = "https://images.unsplash.com/photo-1651008376811-b90baee60c1f?q=80&w=200&auto=format&fit=crop" },

                // Pediatrics
                new Doctor { Id = 5, Name = "Dr. Omar Khaled", Specialty = "Pediatrics", ImageUrl = "https://images.unsplash.com/photo-1612349317150-e413f6a5b16d?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 6, Name = "Dr. Mona Said", Specialty = "Pediatrics", ImageUrl = "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?q=80&w=200&auto=format&fit=crop" },

                // Orthopedics
                new Doctor { Id = 7, Name = "Dr. Khaled Ibrahim", Specialty = "Orthopedics", ImageUrl = "https://images.unsplash.com/photo-1637059824899-a441006a6875?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 8, Name = "Dr. Dina Mostafa", Specialty = "Orthopedics", ImageUrl = "https://images.unsplash.com/photo-1594824813573-246434e33963?q=80&w=200&auto=format&fit=crop" },

                // Neurology
                new Doctor { Id = 9, Name = "Dr. Youssef Adel", Specialty = "Neurology", ImageUrl = "https://images.unsplash.com/photo-1622253692010-333f2da6031d?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 10, Name = "Dr. Rana Tarek", Specialty = "Neurology", ImageUrl = "https://images.unsplash.com/photo-1651008376811-b90baee60c1f?q=80&w=200&auto=format&fit=crop" },

                // General
                new Doctor { Id = 11, Name = "Dr. Hossam Nabil", Specialty = "General", ImageUrl = "https://images.unsplash.com/photo-1537368910025-700350fe46c7?q=80&w=200&auto=format&fit=crop" },
                new Doctor { Id = 12, Name = "Dr. Layla Hassan", Specialty = "General", ImageUrl = "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?q=80&w=200&auto=format&fit=crop" }
            );
        }
    }
}
