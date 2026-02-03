using System.Collections.Generic;
namespace BookStoreSysytem;
public class Customer : User 
{
    
    public Cart Cart = new Cart();
    public List<Order> Orders = new List<Order>();

    
    public Customer(String name ,String email,String password):base(name,email,password)
    {
        
    }
    
    
    
    
}