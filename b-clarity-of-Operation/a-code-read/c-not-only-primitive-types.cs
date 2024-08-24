#region Evite
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

    public Employee 
    {
        // Valida E-mail novamente
    }
}

#endregion

#region Utilize

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

#endregion