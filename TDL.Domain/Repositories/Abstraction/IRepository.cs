namespace TDL.Domain.Repositories.Abstraction
{

    using System;
    using System.Collections.Generic;

    public interface IRepository<TItem> : IDisposable
    {
        /// <summary>
        /// Adding item in storage.
        /// </summary>
        /// <param name="item">Adding item.</param>
        /// <returns>Added item.</returns>
        TItem Add(TItem item);

        /// <summary>
        /// Updating item in storage.
        /// </summary>
        /// <param name="item">Updating item.</param>
        /// <returns>Updated item.</returns>
        TItem Update(TItem item);

        /// <summary>
        /// Getting item from storage by id.
        /// </summary>
        /// <param name="id">Key for search item in storage.</param>
        /// <returns>Found item.</returns>
        TItem Get(int id);
        /// <summary>
        /// Getting item from storage by delegate Pridicate.
        /// </summary>
        /// <param name="predicate">Delegate predicate for search item.</param>
        /// <returns>Found item.</returns>
        TItem Get(Predicate<TItem> predicate);
        /// <summary>
        /// Getting all items from storage.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TItem> GetItems();
        /// <summary>
        /// Getting all items from storage.
        /// </summary>
        /// <param name="predicate">Delegate predicate for search.</param>
        /// <returns></returns>
        IEnumerable<TItem> GetItems(Func<TItem, bool> predicate);

        /// <summary>
        /// Removing item from storage by id.
        /// </summary>
        /// <param name="id">Key for search item.</param>
        /// <returns>Deleted item.</returns>
        TItem Remove(int id);
        /// <summary>
        /// Removing item from storage by item properties.
        /// </summary>
        /// <param name="item">Item that has properties for deleting.</param>
        /// <returns>Deleted item.</returns>
        TItem Remove(TItem item);
    }
}
