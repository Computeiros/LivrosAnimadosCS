using LivrosAnimados.Core.DomainObjects;
using System;
using System.Threading.Tasks;

namespace LivrosAnimados.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
