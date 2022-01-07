// Evite
public class CustomerRepository 
{
    public void CreateOrUpdate(Customer customer, bool create)
    {
        if(create)
            ...
        else
            ...
    }
}

// Utilize
public class CustomerRepository 
{
    public void Create(Customer customer) { ... }
    public void Update(Customer customer) { ... }
}