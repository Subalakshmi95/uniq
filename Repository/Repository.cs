using Microsoft.EntityFrameworkCore;
using uniqAPI.data;
using uniqAPI.Models;

namespace uniqAPI.Repository
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _ctx;
        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task CreateAsync(Consumer consumer)
        {
            await _ctx.ConsumerTable.AddAsync(consumer);
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(int Id)
        {
            var data = await GetByIdAsync(Id);
            if (data != null)
            {
                _ctx.ConsumerTable.Remove(data);
              await  _ctx.SaveChangesAsync();
            }
        }

        public async Task EditAsync(Consumer consumer)
        {
            _ctx.Entry(consumer).State= EntityState.Modified;
            await _ctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<Consumer>> GetAllAsync()
        {
           return await _ctx.ConsumerTable.ToListAsync();
        }

        public async Task<Consumer> GetByIdAsync(int Id)
        {
            return await _ctx.ConsumerTable.FindAsync(Id);
        }
    }
}
