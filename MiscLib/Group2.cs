using System;

namespace MiscLib
{
    public class GroupTwoFunctions
    {
        //---- Group 2 Functions ----------
        public int CalcRectPerimeter(int length, int width)
        {
            return (length + width) * 2;
        }

        public bool IsTriangularNum(int num)
        {
            long calc_num = 8 * num + 1;
            long t = (long)Math.Sqrt(calc_num);

            if (t * t == calc_num)
            {
                return true;
            }
            return false;

        }

        public int FarenheitToCelcius(int farenheit)
        {
            throw new NotImplementedException();
        }

        public bool CheckWhiteSpace(string word)
        {
            throw new NotImplementedException();
        }

        public string CamelString(string word)
        {
            throw new NotImplementedException();
        }

        public int CountDigits(string word)
        {
            throw new NotImplementedException();
        }


    }
}
