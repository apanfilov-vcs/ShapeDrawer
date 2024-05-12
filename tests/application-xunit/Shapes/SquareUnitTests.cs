using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain.Shapes;
using Xunit;

namespace application_xunit.Shapes
{
    public class SquareUnitTests : UnitTest
    {
        [Fact]
        public void TestDrawing2x2Square()
        {
            // Arrange
            int size = 2;
            char fillCharacter = '#';
            string expected = "##\n##\n";
            Square square = _shapeApp.CreateSquare(size);

            // Act
            square.Draw(fillCharacter);

            // Assert
            Assert.Equal(expected, Output);
        }

        [Fact]
        public void TestDrawing13x13Square()
        {
            // Arrange
            int size = 13;
            char fillCharacter = '#';
            string expected = "#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n#############\n";
            Square square = _shapeApp.CreateSquare(size);

            // Act
            square.Draw(fillCharacter);

            // Assert
            Assert.Equal(expected, Output);
        }
    }
}