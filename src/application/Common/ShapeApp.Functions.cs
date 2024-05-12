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

        public Rectangle CreateRectangle(int width, int height)
        {
            var rectangle = new Rectangle(width, height)
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
    }
}