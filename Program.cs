using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            const int sizeX = 10;
            const int sizeY = 5;
            if (Math.Abs(x) < sizeX && Math.Abs(y) > sizeY)
            {
                Console.WriteLine("да");
                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {
                if (Math.Abs(x) > sizeX || Math.Abs(y) < sizeY)
                {
                    Console.WriteLine("нет");
                    Console.WriteLine();
                    Console.ReadLine();
                }
                else
                {

                Console.WriteLine("на границе");
                    Console.WriteLine();
                    Console.ReadLine();

                }
            }
        }
    }
} 
