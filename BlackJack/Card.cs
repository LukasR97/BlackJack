using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public string Face { get; set; }
        public int Value { get; set; } = 2;

        public Card(string face, int value)
        {
            this.Face = face;
            this.Value = value;
        }
    }
}
