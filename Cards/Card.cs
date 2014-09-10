using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }  

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value; 
        }

        public string Name
        {
            get { return Value + " of " + Suit;}
        } 
    }
}
