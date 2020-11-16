using System;
using System.Collections.Generic;
using System.Text;

namespace Magic
{
    class Card
    {
        string Name { get; set; }
        //Cost is a string where the number is grey mana and the letters are colored mana r = red, b = blue, g = green, d = dark, w = white
        string Cost { get; set; }
        int Strength { get; set; }
        int Toughness { get; set; }
        string Desc { get; set; }

        public Card() 
        {     
            
        }

        public Card(string name, string cost, string desc) //Non-Creature
        {
            Name = name;
            Cost = cost;
            Desc = desc;
        }
        public Card(string name, string cost, int strength, int toughness, string desc) //Creature
        {
            Name = name;
            Cost = cost;
            Strength = strength;
            Toughness = toughness;
            Desc = desc;
        }
    }
}
