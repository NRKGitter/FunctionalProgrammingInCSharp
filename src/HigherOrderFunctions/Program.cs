using System;

namespace HigherOrderFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(args[0]);
            var result = true;
            for (int i = 2; i < number; i++)
            {
                if ( number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
