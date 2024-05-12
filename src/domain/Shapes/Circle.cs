using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.Shapes
{
	public class Circle : Shape
	{
		public int Radius { get; set; }

		public Circle(int radius)
		{
			Radius = radius;
		}

		// get user input for radius
		public Circle()
		{
			Console.WriteLine("Please enter the radius of the circle: ");
			Radius = int.Parse(Console.ReadLine());
		}
		public override string Draw(char fillCharacter)
		{
			Output = string.Empty;

			for (int i = 0; i <= 2 * Radius; i++)
			{
				for (int j = 0; j <= 2 * Radius; j++)
				{
					if (Math.Pow(i - Radius, 2) + Math.Pow(j - Radius, 2) <= Math.Pow(Radius, 2))
					{
						Output += fillCharacter;
					}
					else
					{
						Output += " ";
					}
				}
				Output += "\n";
			}

			return base.Draw(fillCharacter);
		}

	}
}