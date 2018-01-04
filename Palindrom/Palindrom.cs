using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Palindrom
    {

        public bool FindPalindrom(String inputString)
        {
            String str =  inputString.Replace(" ", "").ToUpper();
            int length = str.Length;
            for (int i=0; i<length/2; i++)
            {
                if (str[i] != str[length - i -1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
