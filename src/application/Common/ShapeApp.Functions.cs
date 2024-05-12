using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain;
using domain.Shapes;

namespace application.Common
{
    public partial class ShapeApp
    {
        public Square CreateSquare(int size)
        {
            var square = new Square(size)
            {
                OutputHandler = this.OutputHandler
            };

            return square;
        }
		// CreateSquere with no parameters
		public Square CreateSquare()
		{
			var square = new Square()
			{
				OutputHandler = this.OutputHandler
			};

			return square;
		}

		public Rectangle CreateRectangle(int width, int height)
        {
            var rectangle = new Rectangle(width, height)
            {
                OutputHandler = this.OutputHandler
            };

            return rectangle;
        }
		// CreateRectangle with no parameters
		public Rectangle CreateRectangle()
		{
			var rectangle = new Rectangle()
			{
				OutputHandler = this.OutputHandler
			};

			return rectangle;
		}

		public Circle CreateCircle(int radius)
        {
            var circle = new Circle(radius)
            {
                OutputHandler = this.OutputHandler
            };

            return circle;
        }
		// CreateCircle with no parameters
		public Circle CreateCircle()
		{
			var circle = new Circle()
			{
				OutputHandler = this.OutputHandler
			};

			return circle;
		}
	}
}