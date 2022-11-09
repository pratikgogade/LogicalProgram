using System;
using System.Collections.Generic;
namespace Learning
{
    public class DayOff
    {
        public void Dati()
        {
            int y = 2022;
            int m = 11;
            int d = 05;

            int y0 = y - ((14 - m) / 12);

            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);

            int m0 = m + 12 * ((14 - m) / 12) - 2;

            int d0 = (d + x + 31 * m0 / 12) % 7;

            Console.WriteLine(Convert.ToInt32(d0));


            switch (d0)

            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thrusday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
            }
        }
    }
}