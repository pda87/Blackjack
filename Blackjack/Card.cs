using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        // Card CLASS TO HOLD INFORMATION ABOUT EACH PLAYING CARD IN THE GAME
        // THE CARDS WILL ULTIMATELY BE ADDED TO LISTS - IE THE COMPLETE DECK, OR A LIST
        // OF EACH PLAYER'S CARDS
        public int Value { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
