using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class FibonacciSeries
    {
        public void Fibonacci(int num)
        {
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.WriteLine("First no. - " + firstNum + "\n" + "Second no. - " + secondNum);
            for (int i = 0; i < num; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.WriteLine(thirdNum);
            }
        }

    }
}