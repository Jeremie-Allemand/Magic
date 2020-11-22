using System;
using System.Collections.Generic;
using System.Text;

namespace Magic
{

    class Deck
    {
        List<Card> Cards;
        public Deck() 
        {
            Cards = new List<Card>();
            for (int i = 0; i < 10; i++)
            {
                Cards.Add(new Card(i.ToString(),"",""));
            }

        }
    }
}
