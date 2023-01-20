// Exercise 1: Define a class called Student with properties such as Name, Age, and Grade. 
// Now add a method called GetStudentInfo that prints all the properties of the student.

// Solution:
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public void GetStudentInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}



// Exercise 2: Define a class called Car with properties such as Brand and Model. 
// Now add a method called StartEngine that prints "Engine started" and a method called StopEngine that prints "Engine stopped".

// Solution:
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public void StartEngine()
    {
        Console.WriteLine("Engine started");
    }
    public void StopEngine()
    {
        Console.WriteLine("Engine stopped");
    }
}
