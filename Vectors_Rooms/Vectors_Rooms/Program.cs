namespace Vectors_Rooms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] rooms = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int numberOfRents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRents; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Student name: ");
                string name = Console.ReadLine();
                Console.Write("Student email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                rooms[room] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }
        }
    }
}