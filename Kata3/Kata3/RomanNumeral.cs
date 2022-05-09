using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
                if (number > 0 && number < 10)
                {
                    sb.Append(numbers1To9(number));
                    i = i + (number - 1);
                }
                else
                {
                    sb.Append(base10Conversion(number, "X", "L", "C"));
                    break;
                }

            }

            return sb.ToString();
        }

        public string RomanNumeralFrom(int number)
        {
            return
                new string('I', number)
                    .Replace(new string('I', 1000), "M")
                    .Replace(new string('I', 900), "CM")
                    .Replace(new string('I', 500), "D")
                    .Replace(new string('I', 400), "CD")
                    .Replace(new string('I', 100), "C")
                    .Replace(new string('I', 90), "XC")
                    .Replace(new string('I', 50), "L")
                    .Replace(new string('I', 40), "XL")
                    .Replace(new string('I', 10), "X")
                    .Replace(new string('I', 9), "IX")
                    .Replace(new string('I', 5), "V")
                    .Replace(new string('I', 4), "IV");
        }

        public string base10Conversion(int number, string denominator, string mid, string upper)
        {
            StringBuilder sbt = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                if (i % 10 == 0)
                {
                    sbt.Append(denominator);
                    i = i + (number - 1);
                }

                if (i % 20 == 0)
                {
                    sbt.Append(denominator);
                    i = i + (number - 1);
                }

                if (i % 50 == 0)
                {
                    sbt.Replace(sbt.ToString(), mid);
                }

                if (number % 40 == 0)
                {
                    sbt.Clear();
                    sbt.Append(denominator + mid);
                }

                if (number % 90 == 0)
                {
                    sbt.Clear();
                    sbt.Append(denominator + upper);
                }

            }

            return sbt.ToString();
        }

        public string numbers1To9(int number)
        {
            StringBuilder sb1To9 = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                sb1To9.Append("I");

                if (i % 5 == 0)
                {
                    sb1To9.Replace(sb1To9.ToString(), "V");
                }

                if (number == 4)
                {
                    sb1To9.Clear();
                    sb1To9.Append("IV");
                }

                if (number == 9)
                {
                    sb1To9.Clear();
                    sb1To9.Append("IX");
                }

            }

            return sb1To9.ToString();
        }

        // Code below was taken from stack overflow
        static Tuple<IList<Tuple<string, int>>, int> GenerateBaseNumbers()
        {
            const string letters = "IVXLCDM";

            var tuples = new List<Tuple<string, int>>();
            Tuple<string, int> subtractor = null;

            int num = 1;
            int maxNumber = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                string currentLetter = letters[i].ToString();

                if (subtractor != null)
                {
                    tuples.Add(Tuple.Create(subtractor.Item1 + currentLetter, num - subtractor.Item2));
                }

                tuples.Add(Tuple.Create(currentLetter, num));

                bool isEven = i % 2 == 0;

                if (isEven)
                {
                    subtractor = tuples[tuples.Count - 1];
                }

                maxNumber += isEven ? num * 3 : num;
                num *= isEven ? 5 : 2;
            }

            return Tuple.Create((IList<Tuple<string, int>>)new ReadOnlyCollection<Tuple<string, int>>(tuples), maxNumber);
        }

        static readonly Tuple<IList<Tuple<string, int>>, int> RomanBaseNumbers = GenerateBaseNumbers();

        public string FromNumberToRoman(int num)
        {
            if (num <= 0 || num > RomanBaseNumbers.Item2)
            {
                throw new ArgumentOutOfRangeException();
            }

            StringBuilder sb = new StringBuilder();

            int i = RomanBaseNumbers.Item1.Count - 1;

            while (i >= 0)
            {
                var current = RomanBaseNumbers.Item1[i];

                if (num >= current.Item2)
                {
                    sb.Append(current.Item1);
                    num -= current.Item2;
                }
                else
                {
                    i--;
                }
            }

            return sb.ToString();
        }
    }
}
