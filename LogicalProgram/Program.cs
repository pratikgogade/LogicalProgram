using System;
namespace LogicalProblem

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programming Problems");
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Perfect Number" + "\n" + "3. Prime Number " + "\n" + "4. Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Fibonacci(10);
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.Perfect(28);
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Prime(5);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}