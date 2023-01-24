// Exercise 1: Create a class called Person with a private field _name and a public property Name. 
// Also add a private field _age and a public property Age. Now create a constructor that initializes the fields and a method Greet that returns a greeting message using the person's name. 
// In main method create a new object of the class and assign a name and age to it then call the greet method.

// Solution: 

class Person
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private int _age;
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
    public string Greet()
    {
        return "Hello, my name is " + _name + " and I am " + _age + " years old.";
    }
}




// Exercise 2: Create a class called Book with private fields such as _title, _author, _pages, and _price. 
// Now add a constructor that initializes these fields and public properties that provide read-only access to the fields. 
// Also add a method called GetBookInfo that returns a string with the book's title, author, number of pages, and price. 
// Create an object of the class and call the method to get the book's information.


// Solution:

class Book
{
    private string _title;
    private string _author;
    private int _pages;
    private double _price;
    public Book(string title, string author, int pages, double price)
    {
        _title = title;
        _author = author;
        _pages = pages;
        _price = price;
    }
    public string Title { get { return _title; } }
    public string Author { get { return _author; } }
    public int Pages { get { return _pages; } }
    public double Price { get { return _price; } }
    public string GetBookInfo()
    {
        return "Title: " + _title + ", Author: " + _author + ", Pages: " + _pages + ", Price: $" + _price;
    }
}
