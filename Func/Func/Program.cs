using System.Globalization;
namespace Action
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

            List<string> productNames = products.Select(UpperName).ToList(); // Recebe uma lista de produtos e devolve uma nova lista com os nomes dos produtos.
            
            Func<Product, string> func = p => p.Name.ToUpper(); // Expressão lambda inserida em uma variável seguida da chamada do select com a referência da variável.
            List<string> productNames2 = products.Select(func).ToList();

            List<string> productNames3 = products.Select(product => product.Name.ToUpper()).ToList(); // Expressão lambda inline.
            
            
            productNames.ForEach(name => Console.WriteLine(name));
            productNames2.ForEach(name => Console.WriteLine(name));
            productNames3.ForEach(name => Console.WriteLine(name));

        }
        public static string UpperName(Product product)
        {
            return product.Name.ToUpper();
        }
    }
}
