using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(16));
        }

        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            var NumberLength = n.ToString().Length;
            if (NumberLength == 1)
            {
                return (int)n;
            }
            else
            {
                char[] arr = n.ToString().ToCharArray();
                var Reduced = arr.Select(a => int.Parse(a.ToString())).Sum();
                return DigitalRoot(Reduced);
            }
            /*
             Optimized solutions
              return (int)(1 + (n - 1) % 9);
              becuase the breaking condition is the number's length is on
             */
        }
    }
}
