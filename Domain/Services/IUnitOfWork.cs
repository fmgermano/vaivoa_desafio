using System;
using System.Threading.Tasks;
using vvef.Domain.Repositories;

namespace vvef.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        ICardRepository Cards { get; }
        IClienteRepository Clients { get; }
        Task<int> CommitAsync();
    }
}