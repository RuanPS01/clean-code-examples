// Objeto de valor, representa um endereço, sua estrutura de dados
public class Address
{
    public string ZipCode { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}

// Objeto do cliente... com seus comportamentos
public class Customer
{
    public Address BillingAddress { get; private set; }
    public Address ShippingAddress { get; private set; }

    public void ChangeBillingAddress(Address address) { ... }
    public void ChangeShippingAddress(Address address) { ... }
}