using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class CouponNumber
    {
        public static int GenerateRandom()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 11);
            return randomNum;
        }
        public static void GenerateCoupon(int num)
        {
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                int random = GenerateRandom();
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] == random)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    arr[i] = random;
                }
            }
            foreach (var data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}