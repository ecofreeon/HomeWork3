using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class IsEvenClass
    {
        public static bool IsEven(this int number)
        {
            return number%2 == 0;
        }
    }
}
