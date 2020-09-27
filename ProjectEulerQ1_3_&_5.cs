using System;
using System.Diagnostics;

namespace peCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

     ProjectEulerQ2_Fibonacci x = new  ProjectEulerQ2_Fibonacci();

     x.Solve(args);
            
            // Stopwatch s = new Stopwatch();
            // s.Start();

            
            // int upperLimit = Int32.Parse(args[0]);
            // int i = 0;
            // int sumAnswer = 0;

            // for (i = 0; i < upperLimit; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //     sumAnswer+=i; 
            //     }

            //     else if(i % 5 == 0)
            //     {
            //     sumAnswer+=i;
            //     }
                
            // }
            // System.Console.WriteLine(sumAnswer);
            // s.Stop();
            // System.Console.WriteLine("Elapsed time = {0} ms", s.ElapsedMilliseconds);
        }
    }
}
