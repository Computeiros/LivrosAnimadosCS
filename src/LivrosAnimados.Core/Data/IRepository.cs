using LivrosAnimados.Core.DomainObjects;
using System;

namespace LivrosAnimados.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
