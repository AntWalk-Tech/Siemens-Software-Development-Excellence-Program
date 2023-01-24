// Exercise 1: Define a class called Bank with a private field _accounts of type List<BankAccount> and a public property Accounts that provides read-only access to the _accounts field. 
// Now add a private method AddAccount that takes a BankAccount object and adds it to the _accounts list and a public method OpenAccount that calls the AddAccount method and provides a public interface for adding a new account to the bank.

// Solution: 

class Bank
{
    private List<BankAccount> _accounts = new List<BankAccount>();
    public IEnumerable<BankAccount> Accounts { get { return _accounts; } }
    private void AddAccount(BankAccount account)
    {
        _accounts.Add(account);
    }
    public void OpenAccount(BankAccount account)
    {
        AddAccount(account);
    }
}



// Exercise 2: Define a class called Car with a private field _speed and a public property Speed. 
// The property should only allow values between 0 and 200 to be set and provide read-only access to the speed field. 
// Additionally, create a private method CheckSpeed that takes an int as an argument and returns a boolean indicating whether the speed is within the valid range (0-200).
// Now use the CheckSpeed method in the setter of the Speed property to validate the incoming value.

// Solution:

class Car
{
    private int _speed;
    public int Speed
    {
        get { return _speed; }
        set
        {
            if (CheckSpeed(value))
                _speed = value;
        }
    }
    private bool CheckSpeed(int speed)
    {
        return speed >= 0 && speed <= 200;
    }
}

