using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string Draw(char fillCharacter)
        {
            Output = string.Empty;
            
            for (var i = 0; i < Height; i++)
            {
                for (var j = 0; j < Width; j++)
                {
                    Output += fillCharacter;
                }

                Output += "\n";
            }

           return base.Draw(fillCharacter);
        }
    }
}