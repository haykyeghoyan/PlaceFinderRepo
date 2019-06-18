using PlaceFinder.DAL.Models;
using PlaceFinder.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaceFinder.DAL.UoW
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private PlaceFinderContext context = new PlaceFinderContext();
        private Repository<Category> categoryRepository;


        public IRepository<Category> CategoryRepository
        {
            get
            {
                return this.categoryRepository ?? new Repository<Category>(context);
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
