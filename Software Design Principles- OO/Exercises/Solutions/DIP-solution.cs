// Exercise: Refactor the following code so that the OrderProcessor class is not dependent on a specific implementation of the INotificationService interface

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

// Solution: In the refactored code, the OrderProcessor class accepts an instance of an interface INotificationService that defines the method for sending the receipt, rather than depending on a specific implementation of the `NotificationServiceclass. 
// This way, theOrderProcessorclass is not dependent on a specific implementation of theINotificationServiceinterface, making it more flexible and easier to change or update the notification service without affecting theOrderProcessor` class.

interface INotificationService
{
    void SendReceipt(Order order);
}
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


// Solution: In this solution, the ShoppingCart class has properties for a list of items, and methods to add and remove items and calculate the total cost. 
// Instead of the ShoppingCart class directly creating instances of the IItem class, it accepts an instance of an interface IItemFactory via the constructor. 
// This interface defines a method for creating items.
// In this way, the ShoppingCart class is not dependent on a specific implementation of the IItem class. 
// It can work with any class that implements the IItemFactory interface and thus create different type of items, making it more flexible and easier to change or update the item class without affecting the ShoppingCart class.

class ShoppingCart
{
    private List<IItem> _items;
    private IItemFactory _itemFactory;

    public ShoppingCart(IItemFactory itemFactory)
    {
        _items = new List<IItem>();
        _itemFactory = itemFactory;
    }

    public void AddItem(string itemName, double price)
    {
        var item = _itemFactory.CreateItem(itemName, price);
        _items.Add(item);
    }

    public void RemoveItem(IItem item)
    {
        _items.Remove(item);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var item in _items)
        {
            totalCost += item.Price;
        }
        return totalCost;
    }
}

interface IItemFactory
{
    IItem CreateItem(string itemName, double price);
}
