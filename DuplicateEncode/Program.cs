using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateEncode
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write(DuplicateEncode("recede"));
        }

        public static string DuplicateEncode(string word)
        {
            return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
            /*
             Another solution
              string retval = "";
                  word = word.ToLower();
                  for(int i = 0; i < word.Length; i++)
                    retval += (word.Split(word[i]).Length - 1 > 1 ? ')' : '(');
                  return retval;
             */

        }
    }
}
