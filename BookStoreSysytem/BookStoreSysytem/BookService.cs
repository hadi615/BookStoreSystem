namespace BookStoreSysytem;

public class BookService
{
    public List<Book> Books = new List<Book>();


    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public List<Book> ByCategory(string category)
    {
        List<Book> result = new List<Book>();
        foreach (var b in  Books)
        {
           if (b.Category == category)
           {
               result.Add(b);}
        }
        return result;
    }

    public List<Book> Search(string text)
    {
        List<Book> result = new List<Book>();
        foreach ( var b in Books)
        {
            if(b.Title.Contains(text) || b.Author.Contains(text) )
                result.Add(b);
        } 
        return result;
    }

    public List<Book> OutOfStock()
    {
        
        List<Book> result = new List<Book>();

        foreach (var b in Books )
        {
            if (b.Stock == 0)
            {
                Books.Add(b);
            }
        }
        return result;
    }
    
    
}