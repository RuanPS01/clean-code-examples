#region Evite

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

#endregion

#region Utilize

public class CustomerRepository 
{
    public void Create(Customer customer) { ... }
    public void Update(Customer customer) { ... }
}

#endregion