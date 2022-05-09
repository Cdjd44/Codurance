using System;

namespace Kata3
{
    public class Class1
    {
    }

    public class RomanNumeral
    {
        public RomanNumeral()
        {
        }

        public string convert(int number)
        {
            if (number == 3) { return "I"; }
            if (number == 2) { return "I"; }
            if (number == 1) { return "I"; }
            return "";

        }
    }
}
