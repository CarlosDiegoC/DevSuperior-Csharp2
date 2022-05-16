using System.Globalization;

namespace Static_Members_Dolar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ConversorDeMoeda.DolarParaReais(cotacao, dolares);
        }
    }
}