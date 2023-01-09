using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BusinessLogic
{
    internal class CommonFuntion
    {
        public static string WriteFizzBuzzLogic(int iValue)
        {
            string sResult = string.Empty;
            if (iValue % 5 == 0 && iValue % 3 == 0)
            {
                sResult = "FizzBuzz";
            }
            else if (iValue % 5 == 0)
            {
                sResult = "Buzz";
            }
            else if (iValue % 3 == 0)
            {
                sResult = "Fizz";
            }
            else
            {
                sResult = iValue.ToString();
            }

            return sResult;
        }
    }
}
