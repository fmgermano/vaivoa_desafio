using System.Collections.Generic;
using System.Threading.Tasks;
using vvef.Domain.Models;

namespace vvef.Domain.Services
{
    public interface IClienteService
    {
         Task<IEnumerable<Cliente>> ListAsync();
         
         Task<Cliente> GetClientById(int Id); 
         
         Task<Cliente> CreateClient(Cliente newCliente); 
         
           }
}