namespace revisão.Models;

internal class ContaInvestimento : Conta
{
    public ContaInvestimento(string titular) : base(titular)
    {
        Titular = titular;
    }

    private double Impostos { get; set; }

    public override void CalculoDeTributo()
    {
        Saldo -= 50;
        Impostos += 50;
    }
    public void TotalizadorDeTributos()
    {
        Console.WriteLine($"O total de tributos arrecadados foram de: ${Impostos}");
    }
}
