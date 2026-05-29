using MediBook.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediBook.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Doctor config
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(d => d.Id);
                entity.Property(d => d.Name).IsRequired().HasMaxLength(100);
                entity.Property(d => d.Specialty).IsRequired().HasMaxLength(100);
                entity.Property(d => d.ImageUrl).HasMaxLength(500);
                entity.HasMany(d => d.Appointments).WithOne(a => a.Doctor).HasForeignKey(a => a.DoctorId).OnDelete(DeleteBehavior.Cascade);
            });

            //Appointment config
            modelBuilder.Entity<Appointment>(entity => {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.FullName).IsRequired().HasMaxLength(100);
                entity.Property(a => a.Phone).IsRequired().HasMaxLength(20);
                entity.Property(a => a.Email).IsRequired().HasMaxLength(150);
                entity.Property(a => a.AppointmentDate).IsRequired();
                entity.Property(a => a.Notes).HasMaxLength(1000);
                entity.Property(a => a.QueueNumber).HasDefaultValue(0);
            });
        }
       

    }
}
