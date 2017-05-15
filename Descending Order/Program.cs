using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(1021));
        }

        public static int DescendingOrder(int num)
        {
          
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));

        }
        /*
         Optimaized Solution
         return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
         */
    }
}
