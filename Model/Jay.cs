using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay: ACGambler
    {
        
        public override void FetchNewNumber(object Object, NumbertoneEventArgs eventArgs)
        {
            if (eventArgs.CreatedNumber.IsEven() == true)
            {
                Score++;
            }  
        }

        public Jay() : base("Jay") 
        {
        }
        
    }
}
