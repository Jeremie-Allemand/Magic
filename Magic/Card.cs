using System;
using System.Collections.Generic;
using System.Text;

namespace Magic
{
    class Card
    {
        string Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Effect { get; set; }
        string FlavorText { get; set; }
        string ImgLink { get; set; }
        bool IsPermanent { get;}
        bool IsCreature { get;}
        int Strength { get; set; }
        int Toughness { get; set; }
        bool IsLand { get;}
        bool IsInstant { get;}
        int[] Cost = new int[6]; // grey = [0];  white = [1]; blue = [2]; black = [3]; red = [4]; green = [5]
        public Card() 
        { 
            
        }

        public Card(string name)
        {
            Name = name;
        }

        public void SetType() 
        { 

        }

        public void GetPropierties() 
        {
            
        }

    }
}
