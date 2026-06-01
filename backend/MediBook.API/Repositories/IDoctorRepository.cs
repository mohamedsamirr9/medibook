using MediBook.API.Models;
using System.Threading.Tasks;

namespace MediBook.API.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor>
    {
        Task<IEnumerable<Doctor>> GetBySpecialtyAsync(string specialty);
    }
}
