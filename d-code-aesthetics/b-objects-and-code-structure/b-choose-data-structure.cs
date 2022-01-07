// Usando estruturas
public struct Email 
{
    public Email(string address) 
    { 
        // Permite apenas E-mails hotmail, gmail, yahoo...
    }

    public string Address { get; private set; }
}

public class Customer
{
    public Email Email { get; private set; }
}



// Usando classes
public class Email 
{
    public Email(string address) 
    { 
        // Permite qualquer tipo de E-mail
    }

    public string Address { get; private set; }
}

public class CommonEmail : Email
{
    public Email(string address) 
        : base(address)
    { 
        // Permite apenas E-mails hotmail, gmail, yahoo...
    }        
}

public class Customer
{
    public Email Email { get; private set; }
}