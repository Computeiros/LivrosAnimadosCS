using System.Threading.Tasks;

namespace LivrosAnimados.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
