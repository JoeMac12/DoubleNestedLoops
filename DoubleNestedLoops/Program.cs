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

            int width = 20;
            int height = 150;

            for(int x = 0; x <= width -1; x++)
            {

                //InnerLoop()
                for (int y = 0; y <= height -1; y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("*");
                }
            }

            Console.WriteLine();    


            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);


        }

        //static void InnerLoop(int i)
        //{
        //    for(int j = 0;j < 9;j++)
        //    {
        //        Console.WriteLine(j);
        //    }
        //}
    }
}
