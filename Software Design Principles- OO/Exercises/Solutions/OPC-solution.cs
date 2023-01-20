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

// Solution: The Shape class has been refactored to be abstract, and the Rectangle and Circle classes have been created that inherit from the Shape class. 
// The CalculateArea method in the Shape class has been made abstract and overridden in the Rectangle and Circle classes. 
// This allows for new shapes to be added in the future without modifying the Shape class.

abstract class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public abstract double CalculateArea();
}
class Rectangle : Shape
{
    public override double CalculateArea() => Width * Height;
}
class Circle : Shape
{
    public override double CalculateArea() => Math.PI * Math.Pow(Width / 2, 2);
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

// Solution: 

abstract class Shape
{
    public abstract double CalculateArea();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea() => Width * Height;
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}
