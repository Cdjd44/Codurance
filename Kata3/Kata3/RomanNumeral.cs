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

            for (int i = 0; i < number; i++)
            {
                if (number < 4)
                {
                    sb.Append("I");
                }

                if (number == 4)
                {
                    sb.Append("I");
                    sb.Append("V");
                    break;
                }
                else if (number == 5)
                {
                    sb.Append("V");
                    break;
                }
                else if (i == 0)
                {
                    sb.Append("V");
                    i = 5;
                }
                sb.Append("I");

            }

            return sb.ToString();

        }
    }
}
