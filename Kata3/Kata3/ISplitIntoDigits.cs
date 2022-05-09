using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3
{
    internal interface ISplitIntoDigits<TOutput,TInput>
    {
        public List<TOutput> Split(TInput value);
    }
}
