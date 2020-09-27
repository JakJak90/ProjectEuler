using System;
using System.Diagnostics;

namespace peCSharp
{
    class ProjectEulerQ2_Fibonacci
    {
        public void Solve(string[] args)
        {
            int count = 1;
            int currentNumber = 1;
            int lastNumber = 1;
            int secondLastNumber = 0;
            int evenNumberSum = 0;
            int upperLimit = Int32.Parse(args[0]);

            while ((secondLastNumber + lastNumber) <= upperLimit)
            {
                // Console.WriteLine(count);
                count++;
                currentNumber = lastNumber + secondLastNumber;
                if (currentNumber % 2 == 0)
                {
                    evenNumberSum += currentNumber;
                    secondLastNumber = lastNumber;
                    lastNumber = currentNumber;
                }

                else
                {
                    
                    secondLastNumber = lastNumber;
                    lastNumber = currentNumber;
                }

                // Console.WriteLine("Current number = {0} \nlast number = {1} \nsecond last number = {2} \neven sum = {3}", currentNumber, lastNumber, secondLastNumber, evenNumberSum);
                // Console.WriteLine("***************************************************");  
            }
                Console.WriteLine("Current number = {0} \nlast number = {1} \nsecond last number = {2} \neven sum = {3}", currentNumber, lastNumber, secondLastNumber, evenNumberSum);
           
        }
    }
}