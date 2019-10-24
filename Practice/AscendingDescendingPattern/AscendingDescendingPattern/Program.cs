using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AscendingDescendingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSame("ABDC", "BCDE"));
            Console.ReadLine();
        }

        //Creating a method to check if two strings have the 
        //same ascending and descending pattern. (i.e. AC is
        //ascending whild CA is descending)
        public static bool IsSame(string s1, string s2)
        {
            int st1Length = s1.Length;
            int st2Length = s2.Length;

            //if they aren't the same length then they can't be the same
            if (st1Length != st2Length)
            {
                return false;
            }
            int l = st2Length;

            for (int index = 0; index + 1 < l; index++)
            {
                //changing the letters into numbers
                int st1currentCharValue = (int)s1[index];
                int st1nextCharValue = (int)s1[index + 1];

                int st2currentCharValue = (int)s2[index];
                int st2nextCharValue = (int)s2[index + 1];

                //checking if the pattern matches in each string and if it doesn't, it returns false
                if(st1currentCharValue >= st1nextCharValue && st2currentCharValue >= st2nextCharValue)
                {
                    continue;   
                }
                else if(st1currentCharValue <= st1nextCharValue && st2currentCharValue <= st2nextCharValue)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
