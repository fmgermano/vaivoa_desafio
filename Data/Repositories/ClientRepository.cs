using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vvef.Domain.Models;
using vvef.Domain.Repositories;

namespace vvef.Data.Repositories
{
    public class ClientRepository : Repository<Cliente>, IClientRepository
    {
        public ClientRepository(DbContext context) 
            : base(context)
        { }
        
        public async Task<IEnumerable<Cliente>> GetAllWithMusicsAsync()
        {
            return await MyMusicDbContext.Artists
                .Include(a => a.Cards)
                .ToListAsync();
        }

        public Task<Cliente GetWithCardsByIdAsync(int id)
        {
            return DbContext.Clientes
                .Include(a => a.Cards)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private DbContext DbContext
        {
            get { return Context as DbContext; }
        }
    }
}