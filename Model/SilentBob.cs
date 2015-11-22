using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob: ACGambler
    {
        public SilentBob() : base("SilentBob")
        {
        }

        public override void FetchNewNumber(object Object, NumbertoneEventArgs eventArgs)
        {
            if (eventArgs.CreatedNumber.IsEven() == false)
            {
                Score++;
            }  
        }
    }
}
