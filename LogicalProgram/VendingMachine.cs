using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    public class VendingMachine
    {
        int[] note = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        int[] arr = new int[8];
        int count = 0;
        public void Note(int amount)
        {
            for (int i = 0; i < note.Length; i++)
            {
                if (amount / note[i] >= 1)
                {
                    arr[count] = note[i];
                    count++;
                    amount -= note[i];
                    if (amount != 0)
                    {
                        this.Note(amount);
                    }
                    else
                        return;
                    break;
                }
                else
                    continue;
            }
            if (count > 0)
            {
                Console.WriteLine("Count :--- " + count);
            }
        }
        public void Print()
        {
            int prev = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                if (arr[i] != 0)
                {
                    foreach (var data in arr)
                    {
                        if (arr[i] == data && data != prev)
                        {
                            count++;
                        }
                    }
                    prev = arr[i];
                    if (count > 0)
                    {
                        Console.WriteLine(count + " : " + arr[i]);
                    }
                }
            }
        }
    }
}