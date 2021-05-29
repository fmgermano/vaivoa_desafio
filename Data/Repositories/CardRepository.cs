using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vvef.Domain.Models;
using vvef.Domain.Repositories;

namespace vvef.Data.Repositories
{
    public class CardRepository : BaseRepository<Card>, ICardRepository
    {
        public CardRepository(DbContext context) 
            : base(context)
        { }

        public async Task<IEnumerable<Card>> GetAllWithClientAsync()
        {
            return await DbContext.Cards
                .Include(m => m.Id)
                .ToListAsync();
        }

        public async Task<Card> GetWithArtistByIdAsync(int id)
        {
            return await DbContext.Cards
                .Include(m => m.Clientes)
                .SingleOrDefaultAsync(m => m.Id == id);;
        }

        public async Task<IEnumerable<Card>> GetAllWithClientsByClientsIdAsync(int ClienteId)
        {
            return await DbContext.Cards
                .Include(m => m.Cliente)
                .Where(m => m.ClienteId == ClienteId)
                .ToListAsync();
        }
        
        private DbContext DbContext
        {
            get { return Context as DbContext; }
        }
    }
}