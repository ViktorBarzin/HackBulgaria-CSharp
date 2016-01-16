namespace LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application class.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Main method.
        /// </summary>
        public static void Main()
        {
            var pr1 = new Product("Chai1", -1, 5);
            var pr2 = new Product("Chai2", 99, 5);
            var pr3 = new Product("Chai3", 100, 124);
            var pr4 = new Product("Chai4", 4, 102);
            var pr5 = new Product("Chai5", 5, 101);
            List<Product> products = new List<Product>() { pr1, pr2, pr3, pr4, pr5 };

            var c1 = new Category(5, "name1");
            var c2 = new Category(125, "name2");
            var c3 = new Category(124, "name3");
            var c4 = new Category(102, "name4");
            var c5 = new Category(100, "name5");
            var c6 = new Category(101, "name6");
            List<Category> categories = new List<Category>() { c1, c2, c3, c4, c5, c6 };

            List<int> prl1 = new List<int>() { 99, 4, 100, -1 };
            List<int> prl2 = new List<int>() { 4, 5, -1, 100 };
            List<int> prl3 = new List<int>() { 99, 4, 5 };
            List<int> prl4 = new List<int>() { 100, 91, 5 };

            var or1 = new Order(1, prl1, new DateTime(2001, 1, 1));
            var or2 = new Order(2, prl2, new DateTime(2000, 1, 2));
            var or3 = new Order(3, prl3, new DateTime(2000, 1, 3));
            var or4 = new Order(4, prl4, new DateTime(2000, 1, 8));
            var or5 = new Order(5, prl4, new DateTime(2000, 1, 7));
            var or6 = new Order(6, prl4, new DateTime(2000, 1, 6));
            var or7 = new Order(7, prl4, new DateTime(2000, 1, 14));
            var or8 = new Order(8, prl4, new DateTime(2000, 1, 24));
            var or9 = new Order(9, prl4, new DateTime(2000, 6, 4));
            var or10 = new Order(14, prl4, new DateTime(2000, 2, 4));
            var or11 = new Order(24, prl4, new DateTime(2000, 6, 4));
            var or12 = new Order(34, prl4, new DateTime(2000, 1, 5));
            var or13 = new Order(44, prl4, new DateTime(2000, 3, 4));
            var or14 = new Order(54, prl4, new DateTime(2000, 2, 4));
            var or15 = new Order(64, prl4, new DateTime(2000, 2, 4));
            List<Order> orders = new List<Order>() { or1, or2, or3, or4, or5, or6, or7, or8, or9, or10, or11, or12, or13, or14, or15 };

            DataStore ds1 = new DataStore(orders, categories, products);

            // returns all products with ids between 15 and 30
            var prods = ds1.GetProducts().Where(x => x.CategoryId > 15 && x.CategoryId < 30).ToList();

            // returns all categories with ids between 105 and 125
            var cats = ds1.GetCategories().Where(x => x.CategoryId > 105 && x.CategoryId < 125).ToList();

            // returns first 15 orders sorted by order name
            var ords = ds1.GetOrders().OrderBy(x => x.OrderDate).Take(15);

            // returns first 3 orders which contains a specific productId 
            var newprods = ds1.GetOrders().Where(x => x.Products.Contains(-1)).OrderBy(x => x.OrderDate).ToList();

            // returns all product with the name of the category which they belong to
            var prodCats = from prod in ds1.GetProducts() orderby prod.Name select new { Name = prod.Name };

            // returns all categories together with their products
            var catsAndProds = from cat in categories
                               join prod in products on cat.CategoryId equals prod.CategoryId
                               select new { Category = cat.CategoryName, Prod = prod.Name };

            // All orders together with their products and then print it to the screen.
            // For every product print its category name as well. Sort the result by orderDate.
            var ress = orders.OrderBy(x => x.OrderDate).SelectMany(
                x => x.Products.Select(
                    y => products.Where(
                        z => z.Id == y).Select(
                        z => new
                                 {
                                     Order = x.Id, Product = z.Name
                                 }).FirstOrDefault())).Where(x => x != null).ToList();

            // Console.WriteLine(string.Join(",", ress[0]));
        }
    }
}