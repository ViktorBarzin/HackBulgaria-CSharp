namespace LINQ
{
    using System.Collections.Generic;

    /// <summary>
    /// Class category with product.
    /// </summary>
    public class CategoryWithProduct
    {
        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the product names.
        /// </summary>
        public List<string> ProductNames { get; set; }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        public int CategoryId { get; set; }
    }
}
