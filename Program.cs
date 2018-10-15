using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza variável X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza variável Y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Está no primeiro quadrante");
            }
            else
            { 
                if (x < 0 && y > 0)
                    Console.WriteLine("Está no segundo quadrante");
            
                else
            
                    if (x > 0 && y < 0)
                        Console.WriteLine("Está no quarto quadrante");
            
                    else
            
                        if (x < 0 && y < 0)
                            Console.WriteLine("Está no terceiro quadrante");
            }


        }
    }
}
