#region Evite

public class Pagamento {
    public bool PodeSerPago() {
        if(tipo == ETipoPagamento.Boleto)
        {
            if(vencimento.Day != IsWeekend())
                return true;
        }

        if(tipo == ETipoPagamento.CartaoCredito)
            ...
    }
}

#endregion

#region Utilize

public class PagamentoCartao {
    public virtual bool PodeSerPago() {
        ...
    }
}

public class PagamentoBoleto : Pagamento {
    public override bool PodeSerPago() {
        if(vencimento.Day != IsWeekend())
            return true;
    }
}

#endregion