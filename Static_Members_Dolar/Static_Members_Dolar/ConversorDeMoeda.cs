using System.Globalization;

namespace Static_Members_Dolar
{
    static class ConversorDeMoeda
    {
        static double IOF = 0.06;

        public static void DolarParaReais(double cotacao, double dolares)
        {
            double valorEmReais = dolares * cotacao * (1 + IOF);
            Console.WriteLine("O valor em reais necessário para comprar essa quantidade de dolares é: R$" + valorEmReais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
