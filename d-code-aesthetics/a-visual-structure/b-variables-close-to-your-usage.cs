#region Evite

var total = 0;
public void CreateCustomer() { ... }
public void CreateOrder() { ... }
public void UpdateCustomer() { ... }
public void CalculateTotal() 
{ 
    total = 250; // <- Só é utilizada aqui
}

#endregion

#region Utilize

public void CreateCustomer() { ... }
public void CreateOrder() { ... }
public void UpdateCustomer() { ... }

var total = 0;
public void CalculateTotal() 
{ 
    total = 250;
}

#endregion