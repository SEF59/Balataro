using System;
using System.Collections.Generic;
using System.Text;
namespace Belato
{
    class Card
    {
        string number;
        Suits suit;

        public Card(string number, string suit)
        {
            this.number = number;
            this.number = suit;

            this.suit = Suits.DIAMONDS;

        }
        public int PrintMe()
        {
            Console.WriteLine(this.suit + this.number);
            return 1;
        }
    }

}
