
using System.Threading.Tasks;
using System.Collections.Generic;
using vvef.Domain.Models;

namespace vvef.Domain.Repositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
         Task<IEnumerable<Cliente>> ListAsync();
         Task<IEnumerable<Cliente>> GetAllWithCardsAsync();
         
         Task<Cliente> GetAllWithCardsByIdAsync(int Id);
    }
}