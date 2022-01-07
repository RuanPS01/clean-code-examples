//EVITE
public class Order() //classe auxiliar para o exemplo
{ 
    public Discount Discount { get; set; }
}

public class Discount() //classe auxiliar para o exemplo 
{ 
    public decimal Amount { get; set; }

    public void Apply() { ... }
}

public class OrderHandler() 
{
    var order = new Order();
    order.Discount.Apply(); // <- MAU USO DO MÉTODO HANDLE
}


/////////////////
//UTILIZE
public class Order()
{ 
    public Discount Discount { get; set; }

    public void Place() 
    {
        Discount?.Apply();
    }
}

public class OrderHandler() 
{
    var order = new Order();
    order.Place();
}