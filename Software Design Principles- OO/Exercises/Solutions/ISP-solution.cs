// Exercise 1: Refactor the following code so that the IWorker interface is segregated into smaller interfaces that group related methods together

interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}
class Robot : IWorker
{
    public void Work() { /* Work logic */ }
    public void Eat() { throw new NotImplementedException(); }
    public void Sleep() { throw new NotImplementedException(); }
}

// Solution: The IWorker interface has been refactored into three smaller interfaces: IWorkable, IFeedable, and ISleepable. 
// The Robot class now implements the IWorkable interface and the Human class implements all three interfaces. 
// This way, classes only need to implement the methods that are relevant to them, rather than implementing methods they will not use.

interface IWorkable
{
    void Work();
}
interface IFeedable
{
    void Eat();
}
interface ISleepable
{
    void Sleep();
}
class Robot : IWorkable
{
    public void Work() { /* Work logic */ }
}
class Human : IWorkable, IFeedable, ISleepable
{
    public void Work() { /* Work logic */ }
    public void Eat() { /* Eat logic */ }
    public void Sleep() { /* Sleep logic */ }
}

// Exercise 2: Create an interface that represents a shape. 
// The interface should have methods for calculating the area and perimeter of a shape. 
// Create classes for specific shapes (e.g. rectangle, circle) that implement the shape interface. 
// Each class should only have to implement the methods that are relevant to that specific shape.

interface IShape
{
    // Add properties and methods as needed
    // Add a method to calculate the area of shape
    // Add a method to calculate the perimeter of shape
}

class Rectangle : IShape
{
    // Add properties as needed (e.g. width, height)
    // Implement the method to calculate the area of rectangle
    // Implement the method to calculate the perimeter of rectangle
}

class Circle : IShape
{
    // Add properties as needed (e.g. radius)
    // Implement the method to calculate the area of circle
    // Implement the method to calculate the perimeter of circle
}

// Solution:

interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea() => Width * Height;
    public double CalculatePerimeter() => 2 * (Width + Height);
}

class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    public double CalculatePerimeter() => 2 * Math.PI * Radius;
}
