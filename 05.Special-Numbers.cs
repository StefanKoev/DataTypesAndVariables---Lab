using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int lastDigit = num % 10;
                int firststDigit = num / 10;
                int sum = firststDigit + lastDigit;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", num);
                }
                else
                {
                    Console.WriteLine("{0} -> False", num);
                }
            }
        }
    }
}
