using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ACGambler
    {
        protected ACGambler(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public int Score { get; protected set; }
        public abstract void FetchNewNumber(object Object, NumbertoneEventArgs eventArgs);
    }
}
