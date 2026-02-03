namespace BookStoreSysytem;

public class OrderService
{
    public List<Order> AllOrders = new List<Order>();


    public void PlaceOrder(Customer c)
    {
        double total = 0;
        foreach (var item in c.Cart.Items)
        {
            item.Key.Stock -= item.Value;
            total += item.Key.Price * item.Value;
        }

        Order o = new Order(new Dictionary<Book, int>(c.Cart.Items), total);
        c.Orders.Add(o);
        AllOrders.Add(o);
        c.Cart.Items.Clear();

    }
    
}