using Groffe.Pagamentos;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 11 + C# 15 | Closed Hierarchies *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

Console.WriteLine("Hello, World!");

Pagamento[] pagamentos =
[
    new CartaoCredito { Valor = 150.00m, Numero = "0000 0000 0000 0000" },
    new Pix { Valor = 75.50m, Chave = "exemplo@exemplo.com" },
    new Boleto { Valor = 200.00m, CodigoBarras = "1234567890" }
];

foreach (Pagamento pagamento in pagamentos)
{
    Console.WriteLine(ProcessadorPagamentos.SimularPagamento(pagamento));
}