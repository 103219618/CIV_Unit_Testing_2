using System;

namespace MiscLib
{
    public class GroupOneFunctions
    {
        //---- Group 1 Functions ----------
        public int CalcRectArea(int length, int width)
        {
            {
                if ((length > 0) & (width > 0))
                {
                    int RESULT = 2 * (length + width);
                    return RESULT;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool IsFactiorialNum(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

    }

    public int CelciusToFarenheit(int celcius)
    {
        throw new NotImplementedException();
    }

    public bool IsPalindrome(string word)
    {
        throw new NotImplementedException();
    }

    public string StringReplace(string word, char replaceChar, char replacement)
    {
        throw new NotImplementedException();
    }

    public int CharCount(string word, char countCharacter)
    {
        throw new NotImplementedException();
    }


}
}
