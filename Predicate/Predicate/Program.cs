using System.Globalization;
namespace Predicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            products.RemoveAll(product => product.Price >= 100.00); //O delegate recebe um objeto e devolve um booleano.

            foreach(Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}