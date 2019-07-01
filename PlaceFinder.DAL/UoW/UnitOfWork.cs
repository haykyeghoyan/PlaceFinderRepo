using PlaceFinder.DAL.DbContex;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.Repository;
using System;

namespace PlaceFinder.DAL.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private PlaceFinderContext _context = new PlaceFinderContext();
        private readonly Repository<Category> _categoryRepository;
        private readonly Repository<Client> _clientRepository;
        private readonly Repository<Place> _placeRepository;
        private readonly Repository<Product> _productRepository;
        private readonly Repository<User> _userRepository;


        public IRepository<Category> CategoryRepository
        {
            get
            {
                return _categoryRepository ?? new Repository<Category>(_context);
            }
        }

        public IRepository<Client> ClientRepository
        {
            get
            {
                return _clientRepository ?? new Repository<Client>(_context);
            }
        }

        public IRepository<Place> PlaceRepository
        {
            get
            {
                return _placeRepository ?? new Repository<Place>(_context);
            }
        }

        public IRepository<Product> ProductRepository
        {
            get
            {
                return _productRepository ?? new Repository<Product>(_context);
            }
        }

        public IRepository<User> UserRepository
        {
            get
            {
                return _userRepository ?? new Repository<User>(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
