// Sorting with LINQ
// Write a program that sorts a list of products by price in decending order

namespace Lab8
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Q3
    {
        public static void run(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Laptop", 999.99m),
                new Product("Smartphone", 599.99m),
                new Product("Tablet", 399.99m),
                new Product("Smartwatch", 199.99m),
                new Product("Headphones", 89.99m)
            };

            var sortedProducts = products.OrderByDescending(p => p.Price).ToList();

            Console.WriteLine("Products sorted by price (descending):");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }
}