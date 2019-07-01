using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.Repository;

namespace PlaceFinder.DAL.UoW
{
    public interface IUnitOfWork
    {
        IRepository<Category> CategoryRepository { get; }
        IRepository<Client> ClientRepository { get; }
        IRepository<Place> PlaceRepository { get; }
        IRepository<Product> ProductRepository { get; }
        IRepository<User> UserRepository { get; }
        void Dispose();
        void Save();
    }
}