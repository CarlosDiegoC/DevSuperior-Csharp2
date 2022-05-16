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

            products.ForEach(UpdatePrice); // Pode ser feito dessa forma, declarando a função e chamando-a ou de forma funcional como no caso abaixo.
            products.ForEach(p => p.Price += p.Price * 0.1); // O delegate ForEach da coleção List é do tipo Action, estes tem retorno void.

            products.ForEach(product => Console.WriteLine(product));
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}