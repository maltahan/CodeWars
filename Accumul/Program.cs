using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumul
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Accum("ZpglnRxqenU"));
        }

        public static String Accum(string s)
        {
            // your code
            
            StringBuilder NewString = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var UpperLetter = s[i].ToString().ToUpper();
                var SmallLetter = new String(Char.ToLower(s[i]), i);
                NewString.Append(UpperLetter);
                NewString.Append(SmallLetter);
                if (i!=s.Length-1) {
                    NewString.Append("-");
                }                              
            }
            return NewString.ToString();
        }

        /*
         other optomized solution 
          return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
         */
    }



}
