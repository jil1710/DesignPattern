using InterpreterDesignPattern.FilterExpression;
using InterpreterDesignPattern.Model;

namespace InterpreterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Brand = "Nike", Color = "Blue", Price = 150M },
                new Product { Brand = "Adidas", Color = "Red", Price = 90M },
                new Product { Brand = "Nike", Color = "Black", Price = 250M },
                
            };

            var query = "brand:Nike; color:blue; minprice:100; maxprice:300";
            var parser = new ParseQuery();
            var expression = parser.Parse(query);

            var filteredProducts = products.Where(p => expression.Interpret(p)).ToList();

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Found: {product.Brand} {product.Color} priced at ${product.Price}");
            }
        }
    }
}