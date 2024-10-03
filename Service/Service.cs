using uniqAPI.Models;
using uniqAPI.Repository;

namespace uniqAPI.Service
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public async Task CreateConsumerAsync(Consumer consumer)
        {
            await _repository.CreateAsync(consumer);
        }

        public async Task DeleteConsumerAsync(int Id)
        {
            await _repository.DeleteAsync(Id);
        }

        public async Task EditConsumerAsync(Consumer consumer)
        {
            await _repository.EditAsync(consumer);
        }

        public async Task<Consumer> GetConsumerByIdAsync(int Id)
        {
           return await _repository.GetByIdAsync(Id);
        }

        public async Task<IEnumerable<Consumer>> GetConsumerListAsync()
        {
           return await _repository.GetAllAsync();
        }
    }
}
