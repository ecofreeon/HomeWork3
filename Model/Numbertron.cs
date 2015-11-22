using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        
        public event EventHandler<NumbertoneEventArgs> NewNumber;

        protected virtual void OnNewNumber(int newNumber)
        {
            NewNumber?.Invoke(this, new NumbertoneEventArgs(newNumber));
        }

        public void Generate(Random random)
        {
            var RandomNumber = random.Next(0, 100);
            OnNewNumber(RandomNumber);
        }
    }
}
