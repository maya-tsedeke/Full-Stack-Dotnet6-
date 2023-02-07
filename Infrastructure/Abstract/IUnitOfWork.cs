using Domain.Entities;

namespace Infrastructure.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Todo> TodoRepository { get; }
        IGenericRepository<Users> UserRepository { get; }
        Task Commit();
    }
}
