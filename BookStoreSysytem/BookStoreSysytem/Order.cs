namespace BookStoreSysytem;

public class Order
{
    public Dictionary<Book, int> Items ;
    public double Total;
    public DateTime Date;

    public Order(Dictionary<Book, int> items, double total)
    {
        Items = items;
        Total = total;
        Date = DateTime.Now;
    }
}