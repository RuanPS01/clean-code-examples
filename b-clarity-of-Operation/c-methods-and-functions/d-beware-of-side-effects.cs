// Evite
public class Order 
{
    public decimal Total { get; set; }
}

var order = new Order();

// Qualquer um fora da classe Order 
// pode atualizar seu total
order.Total = 250;


// Utilize
public class Order 
{
    public decimal Total { get; private set; }

    public void CalculateTotal() { ... }
}

var order = new Order();

// Total é privado, ninguém de fora consegue 
// modificá-lo, evitando efeitos colaterais
order.Total = 250; // ERRO