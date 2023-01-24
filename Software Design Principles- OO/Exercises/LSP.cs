// Exercise 1: Refactor the following code so that the Bird class and its subclasses can be used interchangeably without causing any errors or unexpected behavior

abstract class Bird
{
    public void Fly()
    {
        // Fly logic
    }
}
class Ostrich : Bird
{
    public void Fly()
    {
        throw new Exception("Ostriches cannot fly.");
    }
}

// Exercise 2: Create a class that represents a bank account. 
// The class should have methods for depositing and withdrawing money. 
// Create subclasses for specific types of bank accounts (e.g. checking, savings) that inherit from the account class. 
// The subclasses should be able to be used interchangeably with the parent class without causing any errors or unexpected behavior.

abstract class BankAccount
{
    // Add properties as needed (e.g. balance)
    // Add a method to deposit money
    // Add a method to withdraw money
}

class CheckingAccount : BankAccount
{
    // Override the method to deposit money
    // Override the method to withdraw money
}

class SavingsAccount : BankAccount
{
    // Override the method to deposit money
    // Override the method to withdraw money
}
