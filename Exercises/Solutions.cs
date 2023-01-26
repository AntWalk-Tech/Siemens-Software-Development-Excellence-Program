//Exercise Questions

// 1. Consider a system that needs to manage a large number of bank accounts. Design a clean, maintainable and efficient solution for handling account transactions, taking into account the following constraints:
//Transactions can be of multiple types, such as deposits, withdrawals, and transfers.
//Each transaction must be atomic, meaning it must either complete successfully or fail without leaving any side effects.
//The system must handle concurrent transactions on the same account without causing any race conditions.

class Account
{
    private decimal balance;
    private readonly object lockObject = new object();

    public decimal Balance { get { return balance; } }

    public void Deposit(decimal amount)
    {
        lock (lockObject)
        {
            balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        lock (lockObject)
        {
            if (amount > balance)
                throw new Exception("Insufficient funds");
            balance -= amount;
        }
    }

    public void Transfer(Account toAccount, decimal amount)
    {
        lock (lockObject)
        {
            if (amount > balance)
                throw new Exception("Insufficient funds");
            balance -= amount;
            toAccount.Deposit(amount);
        }
    }
}


// 2. Create a class hierarchy for representing a library catalog system. The catalog should be able to store books, journals, and periodicals. The classes should be designed in such a way that they are open for extension but closed for modification. The catalog should be able to search for items based on title, author, and publication date. Additionally, the catalog should be able to generate reports of the items in the catalog in various formats such as CSV, JSON and XML.

abstract class Item
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public abstract void Search(string title, string author, DateTime publicationDate);
    public abstract void GenerateReports(string format);
}

class Book : Item
{
    public int ISBN { get; set; }
    public override void Search(string title, string author, DateTime publicationDate)
    {
        if (this.Title == title && this.Author == author && this.PublicationDate == publicationDate)
            Console.WriteLine("Book found");
        else
            Console.WriteLine("Book not found");
    }
    public override void GenerateReports(string format)
    {
        if (format == "csv")
        {
            //generate csv report
        }
        else if (format == "json")
        {
            //generate json report
        }
        else if (format == "xml")
        {
            //generate xml report
        }
    }
}
class Journal : Item
{
    public int Volume { get; set; }
    public override void Search(string title, string author, DateTime publicationDate)
    {
        if (this.Title == title && this.Author == author && this.PublicationDate == publicationDate)
            Console.WriteLine("Journal found");
        else
            Console.WriteLine("Journal not found");
    }
    public override void GenerateReports(string format)
    {
        if (format == "csv")
        {
            //generate csv report
        }
        else if (format == "json")
        {
            //generate json report
        }
        else if (format == "xml")
        {
            //generate xml report
        }
    }
}
class Periodical : Item
{
    public int Frequency { get; set; }
    public override void Search(string title, string author, DateTime publicationDate)
    {
        if (this.Title == title and this.Author == author && this.PublicationDate == publicationDate)
Console.WriteLine("Periodical found");
else
Console.WriteLine("Periodical not found");
}
public override void GenerateReports(string format)
{
if (format == "csv")
{
//generate csv report
}
else if (format == "json")
{
//generate json report
}
else if (format == "xml")
{
//generate xml report
}
}
}


// 3. Design a system for a supermarket checkout counter that can scan products, apply discounts, and calculate the total cost of the purchase. The system should be able to handle multiple types of discounts, such as buy-one-get-one-free, bulk discounts, and coupon discounts. The system should also be able to handle multiple types of products, such as weight-based products and unit-based products. Additionally, the system should be able to handle different types of payments, such as cash, credit card, and gift card.


3.
```c#
class Product
{
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
    public ProductType Type { get; set; }
}
enum ProductType
{
    WeightBased,
    UnitBased
}

class Discount
{
    public decimal Amount { get; set; }
    public DiscountType Type { get; set; }
}
enum DiscountType
{
    BuyOneGetOneFree,
    Bulk,
    Coupon
}

class Checkout
{
    private List<Product> products = new List<Product>();
    private List<Discount> discounts = new List<Discount>();

    public void ScanProduct(Product product)
    {
        products.Add(product);
    }

    public void ApplyDiscount(Discount discount)
    {
        discounts.Add(discount);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.Price * product.Quantity;
}
foreach (var discount in discounts)
{
switch (discount.Type)
{
case DiscountType.BuyOneGetOneFree:
var buyOneGetOneFreeProducts = products.Where(p => p.Type == ProductType.UnitBased);
var buyOneGetOneFreeProductCount = buyOneGetOneFreeProducts.Sum(p => p.Quantity);
var freeProductCount = buyOneGetOneFreeProductCount / 2;
total -= freeProductCount * buyOneGetOneFreeProducts.First().Price;
break;
case DiscountType.Bulk:
var bulkDiscountProducts = products.Where(p => p.Type == ProductType.WeightBased);
var bulkDiscountProductWeight = bulkDiscountProducts.Sum(p => p.Quantity);
if (bulkDiscountProductWeight > 10)
{
total -= (bulkDiscountProductWeight * bulkDiscountProducts.First().Price) * (discount.Amount / 100);
}
break;
case DiscountType.Coupon:
total -= discount.Amount;
break;
}
}
return total;
}
}


// 4. Create a program that simulates a traffic light control system for a four-way intersection. The program should be able to handle different types of traffic, such as cars, trucks, bicycles, and pedestrians. The program should also be able to handle different traffic patterns, such as rush hour and non-peak hours. The program should also be able to handle different weather conditions, such as rain and snow. Additionally, the program should be able to handle emergency vehicles, such as ambulances and fire trucks, and give them priority over other traffic.
class TrafficLightControlSystem
{
    private TrafficLight northLight;
    private TrafficLight southLight;
    private TrafficLight eastLight;
    private TrafficLight westLight;
    private TrafficPattern currentPattern;
    private WeatherCondition currentWeather;

    public TrafficLightControlSystem()
    {
        northLight = new TrafficLight(Direction.North);
        southLight = new TrafficLight(Direction.South);
        eastLight = new TrafficLight(Direction.East);
        westLight = new TrafficLight(Direction.West);
        currentPattern = TrafficPattern.NonPeakHour;
        currentWeather = WeatherCondition.Clear;
    }

    public void HandleTraffic()
    {
        if (currentWeather == WeatherCondition.Rain || currentWeather == WeatherCondition.Snow)
        {
            AdjustForWeather();
        }

        if (currentPattern == TrafficPattern.RushHour)
        {
            AdjustForRushHour();
        }

        CheckForEmergencyVehicles();
    }

    private void AdjustForWeather()
    {
        // adjust traffic lights timing to account for weather conditions
    }

    private void AdjustForRushHour()
    {
        // adjust traffic lights timing to account for rush hour traffic
    }

    private void CheckForEmergencyVehicles()
    {
        // check for emergency vehicles and give them priority
    }
}

class TrafficLight
{
    public Direction Direction { get; set; }
    public bool IsGreen { get; set; }

    public TrafficLight(Direction direction)
    {
        Direction = direction;
        IsGreen = false;
    }

    public void SwitchLight()
    {
        IsGreen = !IsGreen;
    }
}

enum Direction
{
    North,
    South,
    East,
    West
}

enum TrafficPattern
{
    NonPeakHour,
    RushHour
}

enum WeatherCondition
{
    Clear,
    Rain,
    Snow
}

enum VehicleType
{
    Car,
    Truck,
    Bicycle,
    Pedestrian,
    Emergency
}





// 5. Design a system for a warehouse management system that can track the movement of products in the warehouse. The system should be able to handle multiple types of products, such as perishable goods and non-perishable goods. The system should also be able to handle different storage conditions, such as temperature-controlled storage and regular storage. The system should also be able to handle different types of movement, such as receiving, picking, packing, and shipping. Additionally, the system should be able to generate reports on the movement of products in the warehouse.

class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime HireDate { get; set; }
    public EmployeeType Type { get; set; }
    public List<EmployeeTask> Tasks { get; set; }

    public Employee(int employeeId, string firstName, string lastName, string email, EmployeeType type)
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        HireDate = DateTime.Now;
        Type = type;
        Tasks = new List<EmployeeTask>();
    }

    public void AssignTask(EmployeeTask task)
    {
        Tasks.Add(task);
    }

    public void CompleteTask(int taskId)
    {
        var task = Tasks.FirstOrDefault(t => t.TaskId == taskId);
        if (task != null)
        {
            task.Complete();
        }
    }
}

class EmployeeTask
{
    public int TaskId { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public EmployeeTask(int taskId, string description)
    {
        TaskId = taskId;
        Description = description;
        IsCompleted = false;
    }

    public void Complete()
    {
        IsCompleted = true;
    }
}

enum EmployeeType
{
    FullTime,
    PartTime,
    Contractor
}


