namespace Task1Orders;

public class Order
{
    public string ItemTitle{ get; set; }

    private long _phoneNumber;
    public long PhoneNumber
    {
        set
        {
            if (value.ToString().Length == 13)
                _phoneNumber = value;
        }
        get => _phoneNumber;
    }

    private float _price;
    public float Price 
    {
        set
        {
            if (value > 0 & value < 1000)
                _price = value;
        }
        get => _price;
    }
    
    public string DeliveryAddress { get; set; }

    public Order(string itemTitle, long phoneNumber, float price, string deliveryAddress)

    {
        ItemTitle = itemTitle;
        PhoneNumber = phoneNumber;
        Price = price;
        DeliveryAddress = deliveryAddress;
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine(nameof(Order));
        Console.WriteLine($"Item Title: {ItemTitle}\n" +
                          $"Phone Number: {PhoneNumber}\n" +
                          $"Price: {Price}\n" +
                          $"Delivery Address: {DeliveryAddress}");
        Console.WriteLine();
    }
   
}