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
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Perfect Number" + "\n" + "3. Prime Number " + "\n" + "4. Reverse Number " + "\n" + "5. Coupon Number" + "\n" + "6. Exit");
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
                    case 4:
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Reverse(1432);
                        break;
                    case 5:
                        CouponNumber.GenerateCoupon(10);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}