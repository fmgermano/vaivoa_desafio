using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vvef.Domain.Models;
using vvef.Domain.Services;
using vvef.Service;


namespace vvef.Domain.Controllers
{
   
    [Route("api/[controller]")]

    public class ClienteController : Controller
    { 
       private readonly IClienteService _clienteService;
        
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;   
        }

        [HttpGet]
        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var clientes = await _clienteService.ListAsync();
            return clientes;
        }
    }
}