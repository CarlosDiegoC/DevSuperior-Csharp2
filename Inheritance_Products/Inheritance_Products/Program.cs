using System.Globalization;
using Inheritance_Products.Entities;

namespace Inheritance_Products
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'c')
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                else if(ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct importedProduct = new ImportedProduct(name, price, customsFee);
                    products.Add(importedProduct);
                }
                else if(ch == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct usedProduct = new UsedProduct(name, price, manufactureDate);
                    products.Add(usedProduct);
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            products.ForEach(p => Console.WriteLine(p.PriceTag()));
        }
    }
}