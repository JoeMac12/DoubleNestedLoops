using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Double nested loops");
            Console.WriteLine("-------------------");
            Console.WriteLine("A loop within a loop");
            Console.WriteLine();

            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            Console.WriteLine();    


            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);


        }
    }
}
