namespace application;

// class shape
public class Shape
{
	// field name
	private string name;
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	// method draw
	public void Draw()
	{
		// dy print error message
		Console.WriteLine("Shape Draw");
	}
	// ask user to enter the name of the shape
	public void AskUserForName()
	{
		// print message to ask user to enter the name of the shape
		Console.WriteLine("Enter the name of the shape: ");
		// read the name of the shape from the user
		Name = Console.ReadLine();
	}
}

// class circle
public class Circle : Shape
{
	// field radius
	private int radius;
	// method draw
	public void Draw()
	{
		// in console draw a cercle with radius using # symbol
		Console.WriteLine("Circle Draw");
		// draw the circle with radius
		for (int i = 0; i <= 2 * radius; i++)
		{
			for (int j = 0; j <= 2 * radius; j++)
			{
				if (Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2) <= Math.Pow(radius, 2))
				{
					Console.Write("#");
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
	// method to ask user to enter the radius of the circle
	public void AskUserForRadius()
	{
		// print message to ask user to enter the radius of the circle
		Console.WriteLine("Enter the radius of the circle: ");
		// read the radius of the circle from the user
		radius = Convert.ToInt32(Console.ReadLine());
	}

}

// class rectangle
public class Rectangle : Shape
{
	// field width
	private int width;
	// field height
	private int height;
	// method draw
	public void Draw()
	{
		// in console draw a rectangle with width and height using # symbol
		Console.WriteLine("Rectangle Draw");
		// draw the rectangle with width and height
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				Console.Write("#");
			}
			Console.WriteLine();
		}
	}
	// method to ask user to enter the width and height of the rectangle
	public void AskUserForWidthAndHeight()
	{
		// print message to ask user to enter the width of the rectangle
		Console.WriteLine("Enter the width of the rectangle: ");
		// read the width of the rectangle from the user
		width = Convert.ToInt32(Console.ReadLine());
		// print message to ask user to enter the height of the rectangle
		Console.WriteLine("Enter the height of the rectangle: ");
		// read the height of the rectangle from the user
		height = Convert.ToInt32(Console.ReadLine());
	}
}

// class square
public class Square : Shape
{
	// field side
	private int side;
	// method draw
	public void Draw()
	{
		// in console draw a square with side using # symbol
		Console.WriteLine("Square Draw");
		// draw the square with side
		for (int i = 0; i < side; i++)
		{
			for (int j = 0; j < side; j++)
			{
				Console.Write("#");
			}
			Console.WriteLine();
		}
	}
	// method to ask user to enter the side of the square
	public void AskUserForSide()
	{
		// print message to ask user to enter the side of the square
		Console.WriteLine("Enter the side of the square: ");
		// read the side of the square from the user
		side = Convert.ToInt32(Console.ReadLine());
	}
}

