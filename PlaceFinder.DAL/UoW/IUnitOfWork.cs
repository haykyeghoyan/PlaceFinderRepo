using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.Repository;

namespace PlaceFinder.DAL.UoW
{
    public interface IUnitOfWork
    {
        IRepository<Category> CategoryRepository { get; }

        void Dispose();
        void Save();
    }
}