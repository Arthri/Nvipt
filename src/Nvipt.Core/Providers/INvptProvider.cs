namespace Nvipt.Core.Providers
{
    /// <summary>
    /// Defines mechanisms for getting or updating Nvpts.
    /// </summary>
    public interface INvptProvider
    {
        /// <summary>
        /// Initializes this provider.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Adds an Nvpt to the provider.
        /// </summary>
        /// <param name="nvpt">The Nvpt to add.</param>
        /// <returns><see langword="true"/> if the operation succeeded, otherwise <see langword="false"/>.</returns>
        bool Add(Nvpt nvpt);

        /// <summary>
        /// Gets an Nvpt from the provider.
        /// </summary>
        /// <param name="owner">The owner of the Nvpt.</param>
        /// <param name="name">The name of the Nvpt to get.</param>
        /// <returns>An Nvpt owned by <paramref name="owner"/> with the name <paramref name="name"/>.</returns>
        Nvpt Get(int owner, string name);

        /// <summary>
        /// Renames an Nvpt in the provider.
        /// </summary>
        /// <param name="owner">The owner of the Nvpt.</param>
        /// <param name="oldName">The old name of the Nvpt.</param>
        /// <param name="newName">The new name for the Nvpt.</param>
        /// <returns><see langword="true"/> if the operation succeeded, otherwise <see langword="false"/>.</returns>
        bool Rename(int owner, string oldName, string newName);

        /// <summary>
        /// Updates the inventory of an Nvpt in the provider.
        /// </summary>
        /// <param name="owner">The owner of the Nvpt.</param>
        /// <param name="name">The name of the Nvpt.</param>
        /// <param name="inventory">The new inventory for the Nvpt.</param>
        /// <returns><see langword="true"/> if the operation succeeded, otherwise <see langword="false"/>.</returns>
        bool Update(int owner, string name, Inventory inventory);

        /// <summary>
        /// Deletes an inventory from the provider.
        /// </summary>
        /// <param name="owner">The owner of the Nvpt.</param>
        /// <param name="name">The name of the Nvpt.</param>
        /// <returns><see langword="true"/> if the operation succeeded, otherwise <see langword="false"/>.</returns>
        bool Delete(int owner, string name);
    }
}
