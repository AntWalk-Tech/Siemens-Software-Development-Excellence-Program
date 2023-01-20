// Exercise 1: Refactor the following code so that the OrderProcessor class is not dependent on a specific implementation of the INotificationService interface

class OrderProcessor
{
    private INotificationService _notificationService;
    public OrderProcessor(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    public void ProcessOrder(Order order)
    {
        // Process the order
        _notificationService.SendReceipt(order);
    }
}

// Exercise 2: Create a class that represents a shopping cart. 
// The class should have a property for a list of items. 
// Instead of the cart class directly creating instances of the item class, it should accept an instance of an interface that defines methods for creating items.
// This way, the cart class is not dependent on a specific implementation of the item class.

class ShoppingCart
{
    // Add properties and methods as needed
    // Add a method to add item
    // Add a method to remove item
    // Add a method to calculate total cost
    // Accept an instance of an interface that defines methods for creating items, rather than directly creating instances of the item class
}

interface IItemFactory
{
    // Add properties and methods as needed
    // Add a method to create item
}
