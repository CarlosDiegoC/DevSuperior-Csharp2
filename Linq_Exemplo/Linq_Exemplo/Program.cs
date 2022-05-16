namespace Linq_Exemplo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {2, 3, 4, 5};

            numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * 10)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
            
            // O retorno dessa operação é void, por isso não devo atribuí-la a uma variável, isso ocorre devido a conversão em lista com o ToList e em seguida com o ForEach.
            
            // É importante notar que, caso a consulta terminasse no Select, teria um retorno do tipo IEnumerable e seria preciso fazer um foreach como mostrado abaixo.

            var resulto = numbers.Where(n => n % 2 == 0).Select(n => n * 10);
            foreach (int n in resulto)
            {
                Console.WriteLine(n);
            }
        }
    }
}