//Evite
public class Student 
{
    public bool IsSubscriber { get; set; }

    public void Xpto() 
    {
        if(IsSubscriber)
            ... // Só executa se for assinante   
    }
}

//Utilize
public class Student 
{
    ...
}

public class Subscriber : Student
{
    public void Xpto() 
    {
        ...        
    }
}