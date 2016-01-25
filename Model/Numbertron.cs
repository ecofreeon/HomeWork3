using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        private readonly Random _random = new Random();
        public event EventHandler<NumbertoneEventArgs> NewNumber;

        protected virtual void OnNewNumber(int newNumber)
        {
            NewNumber?.Invoke(this, new NumbertoneEventArgs(newNumber));
        }

        public void Generate()
        {
            var randomNumber = _random.Next(0, 1000);
            OnNewNumber(RandomNumber);
        }
    }
}
