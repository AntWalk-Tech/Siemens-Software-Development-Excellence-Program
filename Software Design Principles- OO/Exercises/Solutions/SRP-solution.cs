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


// Solution: The Customer class has been separated into two classes: Customer and CustomerPromotion. 
// The Customer class is responsible for storing customer information, and the CustomerPromotion class is responsible for sending promotional emails to customers. 
// This way, if the way customer information is stored changes, it will not affect the way promotional emails are sent and vice versa.

class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public void Save()
    {
        // Save customer's information to the database
    }
}
class CustomerPromotion
{
    private Customer _customer;
    public CustomerPromotion(Customer customer) => _customer = customer;
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

// Solution: 

class ShoppingCart
{
    private List<Item> items = new List<Item>();
    public void AddItem(Item item) => items.Add(item);
    public void RemoveItem(Item item) => items.Remove(item);
    public double CalculateTotalCost() => items.Sum(item => item.Price);
}

