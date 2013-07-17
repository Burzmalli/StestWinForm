using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StestWinForm
{
    class Card
    {
        private string[] cardTypes = { "Land", "Spell" };
        private string type;

        public Card() { }
        public Card(int typeNum) { type = cardTypes[typeNum]; }
        public string getCardType() { return type; }
    }
}