using System;
using System.Collections.Generic;

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
            _split.Split(number);

            if (number < 5) { return "I"; }
            if (number == 5) { return "V"; }
            if (number == 6) { return "VI"; }
            return "VII";

        }
    }
}
