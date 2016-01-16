namespace LINQ
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class data store.
    /// </summary>
    public class DataStore
    {
        /// <summary>
        /// Contains the list of orders.
        /// </summary>
        private readonly List<Order> orders;

        /// <summary>
        /// Contains the list of products.
        /// </summary>
        private readonly List<Product> products;

        /// <summary>
        /// Contains the list of categories.
        /// </summary>
        private readonly List<Category> categories;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStore"/> class.
        /// </summary>
        /// <param name="orders">Sets list of orders.</param>
        /// <param name="category">Sets list of categories.</param>
        /// <param name="products">Sets list of products.</param>
        public DataStore(List<Order> orders, List<Category> category, List<Product> products)
        {
            this.orders = orders;
            this.products = products;
            this.categories = category;
        }

        /// <summary>
        /// Gets filtered products.
        /// </summary>
        /// <returns>List of Products whose Id is between 1 and 100.</returns>
        public List<Product> GetProducts()
        {
            return this.products.Where(x => x.Id < 100 && x.Id > 1).ToList();
        }

        /// <summary>
        /// Gets filtered categories.
        /// </summary>
        /// <returns>List of categories whose id is between 101 and 200.</returns>
        public List<Category> GetCategories()
        {
            return this.categories.Where(x => x.CategoryId > 101 && x.CategoryId < 200).ToList();
        }

        /// <summary>
        /// Gets filtered orders.
        /// </summary>
        /// <returns>List of orders whose id i between 201 and 300.</returns>
        public List<Order> GetOrders()
        {
            return this.orders.Where(x => x.Id > 201 && x.Id < 300).ToList();
        }
    }
}
