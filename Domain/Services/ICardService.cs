using System.Collections.Generic;
using System.Threading.Tasks;
using vvef.Domain.Models;

namespace vvef.Domain.Services
{
    public interface ICardService
    {
        Task<IEnumerable<Card>> GetAllWithClient();
        Task<Card> GetCardById(int id);
        Task<IEnumerable<Card>> GetCardsByClientId(int ClientId);
        
        Task<IEnumerable<Card>> GetCardsByClientEmail(string Email);
        Task<Card> CreateCard(Card newCard);
        Task UpdateCard(Card cardToBeUpdated, Card card);
        Task DeleteCard(Card card);
    }
}