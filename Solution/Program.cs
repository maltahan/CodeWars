using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Solution(10));
        }
        public static int Solution(int value)
        {
            // Magic Happens
            var sum = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /*
         another solution
          return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
         */
    }
}

