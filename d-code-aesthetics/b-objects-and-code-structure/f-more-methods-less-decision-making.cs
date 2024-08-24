#region Evite
public class Order
{
    public void Pay(CreditCard card)
    {
        if(card == null)
            // Pagamento via boleto

        // Pagamento via cartão
    }
}

#endregion

#region Utilize

public class Order
{
    public void Pay()
    {
        // Pagamento via boleto
    }

    public void Pay(CreditCard card)
    {
        // Pagamento via cartão de crédito
    }
}

#endregion