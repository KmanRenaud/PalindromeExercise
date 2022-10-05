using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string pal)
        {
            if (pal.ToLower() == new string(pal.ToCharArray().Reverse().ToArray()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
