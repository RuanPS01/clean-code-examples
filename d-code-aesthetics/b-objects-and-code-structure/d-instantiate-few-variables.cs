#region Evite
public class ShoppingCart
{
    public decimal Total { get; private set; }

    public decimal CalculateTotal()
    {
        var total = 0; // Desnecessário
        foreach(var item in Items) {
            total += item.Price;
        }
        Total = total
    }
}

#endregion

#region Utilize
public class ShoppingCart
{
    public decimal Total { get; private set; }

    private decimal CalculateTotal()
    {        
        foreach(var item in Items)
            Total += item.Price;
    }
}

#endregion