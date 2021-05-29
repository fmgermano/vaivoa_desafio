using System.Collections.Generic;
using System.Threading.Tasks;
using vvef.Domain.Models;

namespace vvef.Domain.Repositories
{
    public interface ICardRepository : IRepository<Card>
    {
        Task<IEnumerable<Card>> GetAllWithArtistAsync();
        Task<Card> GetWithClientByEmailAsync(string Email);
        Task<IEnumerable<Card>> GetAllWithClientByEmailAsync(string Email);
    }
}