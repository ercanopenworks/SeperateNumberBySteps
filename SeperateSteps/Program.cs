using System;
using System.Collections.Generic;

namespace SeperateSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            var myStack = new Stack<int>();

            while (number>0)
            {
                int k = number % 10;
                myStack.Push(k);
                number /= 10;
            }

            int i = 0;
            int n = myStack.Count-1;

            foreach (var item in myStack)
            {
                var stepValue = Math.Pow(10, n - i);
                Console.WriteLine($"{item} x {stepValue} = {item * stepValue}");
                i++;
            }

        }
    }
}
