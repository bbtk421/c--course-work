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
            List<string> Suits = new List<string>() { "Diamonds", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Five","Six","Seven",
                "Eight","Nine","Ten","Jack","Queen","King","Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);

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
