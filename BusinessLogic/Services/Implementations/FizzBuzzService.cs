using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        int _maxLoop;
        public FizzBuzzService() { }
        public FizzBuzzService(int maxLoop)
        {
            this._maxLoop = maxLoop;
        }
        public string Write()
        {
            string sResult = string.Empty;

            try
            {
                for (int i = 1; i <= _maxLoop; i++)
                {
                    sResult = i.ToString();

                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        sResult = "FizzBuzz";
                    }
                    else if (i % 5 == 0)
                    {
                        sResult = "Buzz";
                    }
                    else if (i % 3 == 0)
                    {
                        sResult = "Fizz";
                    }

                    Console.WriteLine(sResult);
                }

                sResult = string.Empty;
            }
            catch (Exception x)
            {
                string sExc = string.Empty;
                if (x.InnerException != null)
                {
                    sExc = x.InnerException.Message;
                }

                sResult = $"Exception found. \nInnerExc: {sExc},\nMessage: {x.Message}";
            }

            return sResult;
        }
    }
}
