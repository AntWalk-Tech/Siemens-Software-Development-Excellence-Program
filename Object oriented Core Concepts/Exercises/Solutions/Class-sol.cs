// Exercise 1: Create a class called Person with properties such as Name, Age and Gender. 
// Now create an object of this class and initialize the properties using the constructor.

// Solution: 

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}



// Exercise 2: Create a class called Calculator with methods such as Add, Subtract, Multiply and Divide which takes two arguments and returns the result. 
// Now create an object of this class and call these methods to perform arithmetic operations.

// Solution:

class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        return a / b;
    }
}
