using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.Shapes
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override string Draw(char fillCharacter)
        {
            var output = string.Empty;

            for (var i = 0; i < Side; i++)
            {
                for (var j = 0; i < Side; j++)
                {
                    output += fillCharacter;
                }
                output += "\n";
            }

            return output;
        }
    }
}