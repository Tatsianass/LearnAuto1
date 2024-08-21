using Task1Orders;

Order[] myOrders = new Order[4];
myOrders[0] = new Order("Carpet", 3752911111111, (float)11.3, "Warsaw");
myOrders[1] = new VipOrder("Spoon", 3752911111112, (float)12.3, "Wroclaw", "Gift description placeholder");
myOrders[2] = new DiscountOrder("Shoes", 4892911111113, (float)13.3, "Minsk", (float)10);
myOrders[3] = new Order("Whys", 4892911111114, (float)14.3, "Minsk");

// Вывести на экран полную информацию о заказах, телефонный номер заказчика которых начинается на 375.
/*foreach (Order order in myOrders)
{
    //string phoneNumberString = order.PhoneNumber.ToString();
    //bool firstThreeCharacters = phoneNumberString.StartsWith("375");
    if (order.PhoneNumber.ToString().StartsWith("375"))
    {
        order.DisplayInfo();
    }
}*/

// Вывести на экран полную информацию о заказах, стоимость которых не превышает 20 и имя товара начинается на "Whys".
/*foreach (Order order in myOrders)
{
    if (order.ItemTitle.StartsWith("Whys") && order.Price < (float)20)
    {
        order.DisplayInfo();
    }
}*/

foreach (Order order in myOrders)
{
        order.DisplayInfo();
}


