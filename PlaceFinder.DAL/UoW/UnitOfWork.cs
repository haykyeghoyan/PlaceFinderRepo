using PlaceFinder.DAL.DbContex;
using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.Repository;
using System;

namespace PlaceFinder.DAL.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private PlaceFinderContext context = new PlaceFinderContext();
        private readonly Repository<Category> categoryRepository;
        private readonly Repository<Client> clientRepository;

        public IRepository<Category> CategoryRepository
        {
            get
            {
                return this.categoryRepository ?? new Repository<Category>(context);
            }
        }

        public IRepository<Client> ClientRepository
        {
            get
            {
                return this.clientRepository ?? new Repository<Client>(context);
            }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }
    
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
