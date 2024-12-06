using System;

namespace for_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine(sum);
        }
    }
}