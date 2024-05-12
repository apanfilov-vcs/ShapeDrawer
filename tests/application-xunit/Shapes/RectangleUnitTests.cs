using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.Shapes;
using Xunit;

namespace application_xunit.Shapes
{
    public class RectangleUnitTests : UnitTest
    {
        [Fact]
        public void TestDrawing3x2Rectangle()
        {
            // Arrange
            int width = 3;
            int height = 2;
            char fillCharacter = '#';
            string expected = "###\n###\n";
            Rectangle rectangle = _shapeApp.CreateRectangle(width, height);

            // Act
            rectangle.Draw(fillCharacter);

            // Assert
            Assert.Equal(expected, Output);
        }
        [Fact]
        public void TestDrawing4x7Rectangle()
        {
            int width = 4;
            int height = 7;
            char fillCharacter = '#';
            string expected = "####\n####\n####\n####\n####\n####\n####\n";
            Rectangle rectangle = _shapeApp.CreateRectangle(width, height);

            // Act
            rectangle.Draw(fillCharacter);

            // Assert
            Assert.Equal(expected, Output);
        }
    }
}