using uniqAPI.Models;

namespace uniqAPI.Service
{
    public interface IService
    {
        Task CreateConsumerAsync(Consumer consumer);
        Task EditConsumerAsync(Consumer consumer);
        Task DeleteConsumerAsync(int Id);
        Task<IEnumerable<Consumer>> GetConsumerListAsync();
        Task<Consumer>GetConsumerByIdAsync(int Id);
    }
}
