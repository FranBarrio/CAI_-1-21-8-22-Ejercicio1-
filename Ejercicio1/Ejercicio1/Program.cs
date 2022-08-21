using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 239; i++)
            {
                Console.Write(i);
                if (i % 3 == 0)
                {
                    Console.Write("Foo");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Bar");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Presione cualquier tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
