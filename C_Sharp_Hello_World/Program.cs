using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!\n 9u");
            dynamic c= Console.ReadKey();
            Console.WriteLine(c);
            do
            {
                for (int i = 1; i <= 56; i++)
                {
                    if (i == 55)
                    {
                        for (int j = 1; j < 55; j++) i--;
                    }

                    Console.WriteLine(i + " ");
                }
            } while (!Console.KeyAvailable);
            Console.WriteLine();
        }
    }
}
