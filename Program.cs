using System.Globalization;

namespace askhsh_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello, Give me a number");
                int Number = int.Parse(Console.ReadLine());
                while (Number < 0)
                {
                    Console.WriteLine("You can't put a number lower than 0 .Try again.");
                    Console.WriteLine("Give me a number again");
                    Number = int.Parse(Console.ReadLine());
                }  
                sum += Number;            
            }
            float average = sum / 10;
            Console.WriteLine(average);
        }
    }
}
