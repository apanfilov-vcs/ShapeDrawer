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
		// get user input for side
		public Square()
		{
			Console.WriteLine("Please enter the side of the square: ");
			Side = int.Parse(Console.ReadLine());
		}

		public override string Draw(char fillCharacter)
        {
            Output = string.Empty;

            for (var i = 0; i < Side; i++)
            {
                for (var j = 0; j < Side; j++)
                {
                    Output += fillCharacter;
                }
                Output += "\n";
            }

            return base.Draw(fillCharacter);
        }
    }
}