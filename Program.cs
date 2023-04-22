using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ParaPensarEj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("Ingrese un año");
            año = Convert.ToInt32(Console.ReadLine());
            if ((año % 400) == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                if ((año % 4) == 0)
                {
                    if ((año % 100) != 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto");
                }
            }
            Console.ReadKey();
        }   
    }
}
