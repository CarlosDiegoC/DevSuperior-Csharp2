using System.Globalization;
namespace Try_Catch_Division
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Digite os valores para os quais deseja realizar a divisão:");
                Console.Write("Primeiro número: ");
                double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo número: ");
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("O resultado da divisão é: " + (n1 / n2).ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }

            Console.WriteLine("Digite Enter para finalizar: ");
            Console.ReadLine();

        }
    }
}