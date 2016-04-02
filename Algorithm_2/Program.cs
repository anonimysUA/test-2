using System;

namespace Algorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                try
                {
                    Console.Write("Input number: ");
                    int input = Int32.Parse(Console.ReadLine());
                    for (int i = 1; i <= input; i++)
                    {
                        if ((input % i) == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Input numbers please");
                }


            }
        }
    }
}
