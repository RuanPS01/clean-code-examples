public class ShoppingCart
{
    public decimal Total { get; private set; }

    public decimal CalculateTotal()
    {
        var total = 0; // Desnecessário
        foreach(var item in Items)
            total += item.Price;
    }
}