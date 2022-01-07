// Utilize
public void CreateCustomer(string name) 
{ 
    var customer = new Customer(name);
    _repository.Customers.Add(customer);
    _repository.SaveChanges();
}