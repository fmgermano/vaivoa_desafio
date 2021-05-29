using System.Threading.Tasks;
using vvef.Domain;
using vvef.Domain.Repositories;
using vvef.Data.Repositories;

namespace vvef.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private CardRepository _cardRepository;
        private ClientRepository _clientRepository;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

        public ICardRepository Cards => _cardRepository = _cardRepository ?? new CardRepository(_context);

        public IClienteRepository Clientes => _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}