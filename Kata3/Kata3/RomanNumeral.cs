using System;
using System.Collections.Generic;
using System.Text;

namespace Kata3
{
    public class RomanNumeral
    {
        private SplitIntIntoDigits _split;
        public RomanNumeral()
        {
            _split = new SplitIntIntoDigits();
        }

        public string convert(int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                sb.Append("I");

                if(i % 5 == 0)
                {
                    sb.Replace(sb.ToString(), "V");
                }

            }

            return sb.ToString();

        }
    }
}
