using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class TemperatureConversion
    {
        public static void Temperature()
        {
            double finalTemp = 0, tempFinal = 0;
            Console.WriteLine("1. Celsius to Farheniet \n2. Farheniet to celsius");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    Console.WriteLine("Enter temp. in celsius");
                    double celcius = Convert.ToDouble(Console.ReadLine());
                    finalTemp = (celcius * 9 / 5) + 32;
                    Console.WriteLine(finalTemp + "°F");
                    break;
                case 2:
                    Console.WriteLine("Enter temp. in farhenhiet");
                    double farheniet = Convert.ToDouble(Console.ReadLine());
                    tempFinal = (farheniet - 32) * 5 / 9;
                    Console.WriteLine(tempFinal + "°C");
                    break;
                default:
                    Console.WriteLine("Enter your choice Again");
                    break;
            }
        }
    }
}