namespace Groffe.Pagamentos;

public closed class Pagamento
{
    public decimal? Valor { get; set; }
}

public class CartaoCredito: Pagamento
{
    public string? Numero { get; set; }
}

public class Pix: Pagamento
{
    public string? Chave { get; set; }
}

public class Boleto: Pagamento
{
    public string? CodigoBarras { get; set; }
}

public static class ProcessadorPagamentos
{
    static ProcessadorPagamentos()
    {
        Console.WriteLine("Iniciando simulacoes com Processador de Pagamentos...");
        Console.WriteLine();
    }

    public static string SimularPagamento(Pagamento pagamento) => pagamento switch
    {
        CartaoCredito c => $"Processados R$ {c.Valor:F2} no Cartão {c.Numero} [Simulacao]",
        Pix p => $"Processados R$ {p.Valor:F2} via PIX ({p.Chave}) [Simulacao]",
        Boleto b => $"Processados R$ {b.Valor:F2} via Boleto ({b.CodigoBarras}) [Simulacao]"
    };
}