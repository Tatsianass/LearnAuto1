namespace Task1Orders;

public class VipOrder : Order
{
    public string GiftDescription { get; set; }
    
    public VipOrder (string itemTitle, long phoneNumber, float price, string deliveryAddress, string giftDescription) 
    : base (itemTitle, phoneNumber, price, deliveryAddress)
    {
        GiftDescription = giftDescription;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine(nameof(VipOrder));
        Console.WriteLine($"Item Title: {ItemTitle}\n" +
                          $"Phone Number: {PhoneNumber}\n" +
                          $"Price: {Price}\n" +
                          $"Delivery Address: {DeliveryAddress}");
        Console.WriteLine($"Gift Description: {GiftDescription}\n");
    }
}