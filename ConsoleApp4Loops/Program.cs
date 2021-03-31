using System;

namespace ConsoleApp4Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)
            {                
                Console.WriteLine($"Hello World! The counter is {counter++}");
            }
            Console.WriteLine("------------------------");
            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine($"Hello World! The counter is {++counter1}");
            }
            Console.WriteLine("------------------------");
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);
        }
    }
}
