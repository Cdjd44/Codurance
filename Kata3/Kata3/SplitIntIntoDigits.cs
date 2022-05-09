using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3
{
    internal class SplitIntIntoDigits : ISplitIntoDigits<String, int>
    {
        public List<String> Split(int value)
        {
            List<string> SplitList = new List<string>();

            foreach(char c in value.ToString())
            {
                SplitList.Add(c.ToString());
            }

            return SplitList;
        }
    }
}
