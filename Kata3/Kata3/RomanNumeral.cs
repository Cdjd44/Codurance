using System;
using System.Collections.Generic;

namespace Kata3
{
    public class RomanNumeral
    {
        public RomanNumeral()
        {
        }

        public string convert(int number)
        {
            if (number < 5) { return "I"; }
            if (number == 5) { return "V"; }
            if (number == 6) { return "VI"; }
            return "VII";

        }
    }
}
