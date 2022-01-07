//Evite
public class Customer 
{
    public string Email { get; set; }

    public Customer 
    {
        // Valida E-mail
    }
}

public class Employee 
{
    public string Email { get; set; }

    public Customer 
    {
        // Valida E-mail novamente
    }
}

//Utilize
// Value Object
public class Email 
{
    public string Address { get; set; }

    public Email 
    {
        // Valida E-mail
    }
}

public class Customer 
{
    public Email Email { get; set; }
}

public class Employee 
{
    public Email Email { get; set; }
}