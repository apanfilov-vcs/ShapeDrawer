using System.Diagnostics.Contracts;
using application.Common;
using domain;
using domain.Shapes;

var shapeApp = new ShapeBuilder
    .Options()
    .WithOutputHandler(Console.WriteLine)
    .Build();

var rectangle = shapeApp.CreateRectangle(20, 10);

rectangle.Draw('@');