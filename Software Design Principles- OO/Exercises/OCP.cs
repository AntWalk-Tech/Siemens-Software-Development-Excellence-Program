// Exercise 1: Refactor the following code so that the Shape class is open for extension but closed for modification

abstract class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        if (this is Rectangle)
        {
            return Width * Height;
        }
        else if (this is Circle)
        {
            return Math.PI * Math.Pow(Width / 2, 2);
        }
        throw new NotImplementedException();
    }
}

// Exercise 2: Create a class that represents a shape. 
// The class should have a method for calculating the area of the shape. 
// Create subclasses for specific shapes (e.g. rectangle, circle) that inherit from the shape class and override the area calculation method. 
// The shape class should be open for extension (through inheritance) but closed for modification.

abstract class Shape
{
    // Add properties and methods as needed
    // Add a method to calculate the area of shape
}

class Rectangle : Shape
{
    // Add properties as needed (e.g. width, height)
    // Override the method to calculate the area of rectangle
}

class Circle : Shape
{
    // Add properties as needed (e.g. radius)
    // Override the method to calculate the area of circle
}
