using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain
{
	public class Circle : Shape
	{
		public int Radius { get; set; }

		public Circle(int radius)
		{
			Radius = radius;
		}

		public override string Draw(char fillCharacter)
		{
			var output = string.Empty;

			for (int i = 0; i <= 2 * Radius; i++)
			{
				for (int j = 0; j <= 2 * Radius; j++)
				{
					if (Math.Pow(i - Radius, 2) + Math.Pow(j - Radius, 2) <= Math.Pow(Radius, 2))
					{
						output += fillCharacter;
					}
					else
					{
						output += " ";
					}
				}
				output += "\n";
			}

			return output;
		}

	}
}