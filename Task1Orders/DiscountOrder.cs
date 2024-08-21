namespace Task1Orders;

public class DiscountOrder : Order
{
    public float Discount { get; set; }
    
    public DiscountOrder (string itemTitle, long phoneNumber, float price, string deliveryAddress, float discount) 
        : base (itemTitle, phoneNumber, price, deliveryAddress)
    {
        Discount = discount;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine(nameof(DiscountOrder));
        Console.WriteLine($"Item Title: {ItemTitle}\n" +
                          $"Phone Number: {PhoneNumber}\n" +
                          $"Price: {Price}\n" +
                          $"Delivery Address: {DeliveryAddress}");
        Console.WriteLine($"Discount: {Discount}\n");
    }
}