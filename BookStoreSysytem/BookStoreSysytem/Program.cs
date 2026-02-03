using System;

namespace BookStoreSysytem;

class Program
{
    static void Main()
    {
        BookService bookService = new BookService();
        CartService cartService = new CartService();
        OrderService orderService = new OrderService();

        Book b1 = new Book("C# Basics", "Ali", 30, 10, "Programming");
        Book b2 = new Book("Java OOP", "Omar", 40, 5, "Programming");

        bookService.AddBook(b1);
        bookService.AddBook(b2);

        Customer customer = new Customer("Hadi", "hadi@mail.com", "123");

        cartService.Add(customer, b1, 2);
        cartService.Add(customer, b2, 1);

        double total = cartService.Total(customer);
        Console.WriteLine("Total before order = " + total);

        orderService.PlaceOrder(customer);

        Console.WriteLine("Orders count = " + customer.Orders.Count);
        Console.WriteLine("Cart items after order = " + customer.Cart.Items.Count);
        Console.WriteLine("Stock of C# Basics = " + b1.Stock);
    }
}