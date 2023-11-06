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

            int numDigits = 16;

            for(int i = 0; i <= numDigits -1; i++)
            {

                //InnerLoop()
                for (int j = 0; j <= numDigits -1; j++)
                {
                    for(int k = 0; k <= numDigits - 1; k++)
                    {
                        Console.WriteLine(i + " " + j + " " + k);
                    }
                    
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
