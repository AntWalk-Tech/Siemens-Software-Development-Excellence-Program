// Exercise 1: Refactor the following code so that the Customer class has only one reason to change.

class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public void Save()
    {
        // Save customer's information to the database
    }
    public void SendPromotionEmail()
    {
        // Send promotional email to the customer
    }
}

// Exercise 2: Create a class that represents a shopping cart. 
// The class should have methods for adding items, removing items, and calculating the total cost. 
// The class should only have one reason to change - for example, if the calculation for the total cost changes.

class ShoppingCart
{
    // Add properties and methods as needed
    // Add a method to add item
    // Add a method to remove item
    // Add a method to calculate total cost
}