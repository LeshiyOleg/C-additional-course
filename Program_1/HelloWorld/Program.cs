using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("I'd like to study C#!");
            //Console.ReadLine();

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);

            int result = num1 + num2;
            Console.WriteLine(result);

            result = num1 * num2;
            Console.WriteLine(result);

            double average = (double) (num1 + num2) / 2;

            Console.WriteLine(average);

            Console.ReadLine();

        }
    }
}
