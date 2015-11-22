using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NumbertoneEventArgs: Numbertron
    {
        public NumbertoneEventArgs(int createdNumber)
        {
            CreatedNumber = createdNumber;
        }

        public int CreatedNumber { get; }
    }
}
