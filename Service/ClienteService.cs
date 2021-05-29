using System.Collections.Generic;
using System.Threading.Tasks;
using vvef.Domain.Models;
using vvef.Domain.Services;
using vvef.Domain.Repositories;


namespace vvef.Service
{
    public class ClienteService : IClienteService 
    {
     
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> ListAsync()
        { 
            return await _clienteRepository.ListAsync();
        }
    }
}