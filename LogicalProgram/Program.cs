
using Learning;

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
                Console.WriteLine("1. Fibonaccis Series" + "\n" + "2. Perfect Number" + "\n" + "3. Prime Number " + "\n" + "4. Reverse Number " + "\n" + "5. Coupon Number" + "\n" + "6. Temperature Conversion" + "\n" + "7. Day of Week" + "\n" + "8. Stop Watch" + "\n" + "9. Exit");
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
                    case 6:
                        TemperatureConversion.Temperature();
                        break;
                    case 7:
                        DayOff day = new DayOff();
                        day.Dati();
                        break;
                    case 8:
                        StopWatch watch = new StopWatch();
                        watch.Start();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}