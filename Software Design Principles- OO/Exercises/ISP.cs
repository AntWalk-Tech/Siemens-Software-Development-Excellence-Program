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

