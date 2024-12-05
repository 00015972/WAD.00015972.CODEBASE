using Back_End_00015972.Data;
using Back_End_00015972.Models;
using Microsoft.EntityFrameworkCore;
/*  My Studen ID: 00015972   */
namespace Back_End_00015972.Repositories
{
    public class KeyRepository : IKeyRepository_00015972
    {
        private readonly ApplicationDbContext _context;

        public KeyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<KeyItem_00015972>> GetAllKeysAsync()
        {
            return await _context.KeyItems.ToListAsync();
        }

        public async Task AddKeyAsync(KeyItem_00015972 key)
        {
            await _context.KeyItems.AddAsync(key);
        }

        public async Task UpdateKeyAsync(KeyItem_00015972 key)
        {
            _context.KeyItems.Update(key);
        }

        public async Task DeleteKeyAsync(int id)
        {
            var key = await _context.KeyItems.FindAsync(id);
            if (key != null)
            {
                _context.KeyItems.Remove(key);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}