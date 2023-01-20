// Exercise 1: Define a base class Shape with a method CalculateArea() that calculates the area of the shape and a property Width and Height. 
// Now create a derived class Rectangle and Circle which inherits from the base class Shape and override the CalculateArea() method to provide the appropriate calculation for their shape.

//Solution: In this exercise, the base class Shape has a virtual method CalculateArea() that calculates the area of the shape and a property Width and Height. 
// The derived class Rectangle and Circle inherit from the base class Shape and override the CalculateArea() method to provide the appropriate calculation for their shape using override keyword.

class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public virtual double CalculateArea()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
class Circle : Shape
{
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Width / 2, 2);
    }
}



// Exercise 2: Define a base class Animal with a method Move() and a derived class Mammal and Bird which inherits from the base class Animals. 
// Now override the Move() method in the derived class to provide the appropriate behavior for their type of animal.

// Solution: In this exercise, the base class Animals has a virtual method Move() that displays "Moving..." on the console. 
// The derived class Mammal and Bird inherit from the base class Animals and override the Move() method to provide the appropriate behavior for their type of animal using override keyword.

class Animals
{
    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}
class Mammal : Animals
{
    public override void Move()
    {
        Console.WriteLine("Walking...");
    }
}
class Bird : Animals
{
    public override void Move()
    {
        Console.WriteLine("Flying...");
    }
}


// Exercise 3: Define a base class Employee with properties such as name, age, and salary. 
// Now create a derived class Manager which inherits from the base class Employee and has an additional property for the number of employees they manage.

// Solution: In this exercise, the base class Employee has properties such as name, age, and salary. 
// The derived class Manager inherits from the base class Employee using : keyword and has an additional property for the number of employees they manage.

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
}
class Manager : Employee
{
    public int NumberOfEmployees { get; set; }
}
