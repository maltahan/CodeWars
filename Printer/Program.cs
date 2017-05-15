using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(PrinterError("aaaxbbbbyyhwawiwjjjwwm"));
        }

        public static string PrinterError(String s)
        {
            // your code
            List<string> list1 = new List<string>(){ "a","b","c","d","e","f","g","h","i","j","k","l","m" };
            var test = s.Where(a => !list1.Contains(a.ToString()) );
            return test.Count().ToString()+"/"+s.Length.ToString();
        }
    }
}
