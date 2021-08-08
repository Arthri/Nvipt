namespace Nvipt.Core
{
    /// <summary>
    /// Represents a unit of player data.
    /// </summary>
    public class Nvpt
    {
        /// <summary>
        /// Represents this Nvpt's name.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Represents this Nvpt's owner.
        /// </summary>
        public int Owner { get; set; }
        
        /// <summary>
        /// Represents whether or not this Nvpt is private.
        /// </summary>
        public bool Private { get; set; }

        /// <summary>
        /// Represents this Nvpt's inventory.
        /// </summary>
        public Inventory Inventory { get; set; }
    }
}