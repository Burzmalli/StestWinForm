using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace StestWinForm
{
    class Deck
    {
        private List<Card> deckList = new List<Card>();
        private RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        private byte[] box;

        public Deck() { }

        public void shuffle()
        {
            int n = deckList.Count;
            while (n > 1)
            {
                box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                Card value = deckList[k];
                deckList[k] = deckList[n];
                deckList[n] = value;
            }
        }

        public void addCard(Card toAdd)
        {
            deckList.Add(toAdd);
        }

        public Card drawCard(int drawNum)
        {
            if (drawNum < deckList.Count)
            {
                return deckList[drawNum];
            }
            else
            {
                return null;
            }
        }

        public void clearDeck()
        {
            deckList.Clear();
        }
    }
}