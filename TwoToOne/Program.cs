using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            Console.WriteLine(Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
        }
        public static string Longest(string s1, string s2)
        {
            // your code
            var String_One =  string.Join("",new String(s1.Distinct().ToArray()) + new String(s2.Distinct().ToArray()));
            var String_Two = String_One.Distinct().ToArray();
            Array.Sort<char>(String_Two);
            return string.Join("",String_Two);
        }
        /*
         Ohter Optimized Solutions Are 
         return new string ((s1 +s2).Distinct().OrderBy(x=>x).ToArray ());
         return string.Join("",s1.Union(s2).Distinct().OrderBy(x=>x));
         
         */
    }
}
