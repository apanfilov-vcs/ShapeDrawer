using application;

// create a shape object
Shape shape = new Shape();
// ask user to enter the name of the shape
shape.AskUserForName();
// draw the shape
shape.Draw();
// create a circle object
Circle circle = new Circle();
// ask user to enter the name of the circle
circle.AskUserForName();
// ask user to enter the radius of the circle
circle.AskUserForRadius();
// draw the circle
circle.Draw();
// create a rectangle object
Rectangle rectangle = new Rectangle();
// ask user to enter the name of the rectangle
rectangle.AskUserForName();
// ask user to enter the width and height of the rectangle
rectangle.AskUserForWidthAndHeight();
// draw the rectangle
rectangle.Draw();
// create a square object
Square square = new Square();
// ask user to enter the name of the square
square.AskUserForName();
// ask user to enter the side of the square
square.AskUserForSide();
// draw the square
square.Draw();