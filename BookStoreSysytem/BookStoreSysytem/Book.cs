namespace BookStoreSysytem;

public class Book
{
    public string Title;
    public string Author;
    public int Stock;
    public int Price;
    public string Category;

    public Book(String title, String author, int stockQunatity, int price, string category)
    {
        this.Title = title;
        this.Author = author;
        this.Stock = stockQunatity;
        this.Price = price;
        this.Category = category;
    }
}