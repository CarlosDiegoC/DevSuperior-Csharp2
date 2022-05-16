using System.Globalization;
namespace Vectors_Height
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número n de alturas que deseja registrar: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite a altura {i+1} a ser registrada");
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"A média das alturas é: {(vect.Sum()/vect.Length).ToString("F2", CultureInfo.InvariantCulture)}m");

            
            // Alternativa usando a forma clássica para calcular a média:
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            Console.WriteLine($"A média das alturas é: {(sum / vect.Length).ToString("F2", CultureInfo.InvariantCulture)}m");

        }
    }
}