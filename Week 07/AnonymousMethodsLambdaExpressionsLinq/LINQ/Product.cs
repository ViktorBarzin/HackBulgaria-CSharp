namespace LINQ
{
    /// <summary>
    /// Class product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="name">Sets product name.</param>
        /// <param name="id">Sets product id.</param>
        /// <param name="categoryId">Sets product category foreign key.</param>
        public Product(string name, int id, int categoryId)
        {
            this.Name = name;
            this.Id = id;
            this.CategoryId = categoryId;
        }

        /// <summary>
        /// Gets or sets product name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product ID.
        /// </summary> 
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets product category foreign key.
        /// </summary>
        public int CategoryId { get; set; }
    }
}
