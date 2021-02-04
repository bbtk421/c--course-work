using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() // constructor
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++) // looping through faces, creating each card
            {
                for (int j = 0; j < 4; j++) // looping through suits
                {
                    Card card = new Card(); // creates each new card
                    card.Face = (Face)i; // casting to int using the ()
                    card.Suit = (Suit)j;
                    Cards.Add(card); // adds card to deck
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) // shuffle method
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); // temp deck list for shuffling
                Random random = new Random();

                while (Cards.Count > 0) // iterates through list and randomizes the deck
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
        }
    }

}
