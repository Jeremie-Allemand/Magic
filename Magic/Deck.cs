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



        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
