namespace MediBook.API.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        T Create(T entity);
        void Update(T entity);
        Task DeleteAsync(int id);
        Task<int> SaveAsync();

    }
}
