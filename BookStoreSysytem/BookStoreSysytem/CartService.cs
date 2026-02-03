namespace BookStoreSysytem;

public class CartService
{
    public void Add(Customer c, Book b, int q )
    {
        if (c.Cart.Items.ContainsKey(b))
        {
            c.Cart.Items[b] += q;
        }
        else
        {
            c.Cart.Items.Add(b, q);
        }
    }

    public void Remove(Customer c, Book b)
    {
        c.Cart.Items.Remove(b);
    }

    public double Total(Customer c)
    {
        double total = 0;
        foreach (var i in c.Cart.Items )
        {
            total += i.Key.Price * i.Value;
            
        }
        return total;
    }
}