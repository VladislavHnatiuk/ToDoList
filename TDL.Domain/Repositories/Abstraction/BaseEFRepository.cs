namespace TDL.Domain.Repositories.Abstraction
{
    using System;
    using System.Collections.Generic;

    using TDL.Data;

    public abstract class BaseEFRepository<TItem> : IRepository<TItem>
    {
        /// <summary>
        /// Entity Framework API for work with database.
        /// </summary>
        protected TdlDbEntities _dbEntities;

        /// <summary>
        /// Stores value about disposing resources.
        /// </summary>
        protected bool _disposed;

        public BaseEFRepository()
        {
            _dbEntities = new TdlDbEntities();
            _disposed = false;
        }

        /// <summary>
        /// Adding item in storage.
        /// </summary>
        /// <param name="item">Adding item.</param>
        /// <returns>Added item.</returns>
        public abstract TItem Add(TItem item);

        /// <summary>
        /// Updating item in storage.
        /// </summary>
        /// <param name="item">Updating item.</param>
        /// <returns>Updated item.</returns>
        public abstract TItem Update(TItem item);

        /// <summary>
        /// Getting item from storage by id.
        /// </summary>
        /// <param name="id">Key for search item in storage.</param>
        /// <returns>Found item.</returns>
        public abstract TItem Get(int id);
        /// <summary>
        /// Getting item from storage by delegate Pridicate.
        /// </summary>
        /// <param name="predicate">Delegate predicate for search item.</param>
        /// <returns>Found item.</returns>
        public abstract TItem Get(Predicate<TItem> predicate);
        /// <summary>
        /// Getting all items from storage.
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<TItem> GetItems();
        /// <summary>
        /// Getting all items from storage.
        /// </summary>
        /// <param name="predicate">Delegate predicate for search.</param>
        /// <returns></returns>
        public abstract IEnumerable<TItem> GetItems(Func<TItem, bool> predicate);

        /// <summary>
        /// Removing item from storage by id.
        /// </summary>
        /// <param name="id">Key for search item.</param>
        /// <returns>Deleted item.</returns>
        public abstract TItem Remove(int id);
        /// <summary>
        /// Removing item from storage by item properties.
        /// </summary>
        /// <param name="item">Item that has properties for deleting.</param>
        /// <returns>Deleted item.</returns>
        public abstract TItem Remove(TItem item);


        public virtual void Dispose(bool disposing)
        {
            if (_disposed == false)
            {
                if (disposing == true)
                {
                    _dbEntities.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
