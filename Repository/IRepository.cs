using uniqAPI.Models;

namespace uniqAPI.Repository
{
    public interface IRepository
    {
        Task CreateAsync(Consumer consumer);
        Task EditAsync(Consumer consumer);
        Task DeleteAsync(int Id);
        Task<IEnumerable<Consumer>> GetAllAsync();
        Task<Consumer> GetByIdAsync(int Id);
    }
}
