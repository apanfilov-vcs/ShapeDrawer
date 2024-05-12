using System.Diagnostics.Contracts;
using application.Common;
using domain;
using domain.Shapes;

var shapeApp = new ShapeBuilder
    .Options()
    .WithOutputHandler(Console.WriteLine)
    .Build();

Console.WriteLine("Please enter the shape you want to draw (c for Circle, r for Rectangle, s for Square): ");
string userInput = Console.ReadLine();

ShapeType shapeType;
switch (userInput.ToLower())
{
    case "c":
        shapeType = ShapeType.Circle;
        break;
    case "r":
        shapeType = ShapeType.Rectangle;
        break;
    case "s":
        shapeType = ShapeType.Square;
        break;
    default:
        Console.WriteLine("Invalid input. Please enter c for Circle, r for Rectangle, or s for Square.");
        return;
}
// create shape based on shape type
Shape shape = shapeType switch
{
	ShapeType.Circle => shapeApp.CreateCircle(),
	ShapeType.Rectangle => shapeApp.CreateRectangle(),
	ShapeType.Square => shapeApp.CreateSquare(),
	_ => throw new InvalidOperationException("Invalid shape type.")
};
// draw shape
shape.Draw('*');


