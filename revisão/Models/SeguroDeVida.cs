namespace revisão.Models;

internal class SeguroDeVida : Conta
{
    private double Impostos { get; set; }
    public SeguroDeVida(string titular) : base(titular)
    {
        Titular = titular;
    }

    public override void CalculoDeTributo()
    {
        double taxa = Saldo * 0.02;
        Saldo -= taxa;
        Impostos += taxa;

    }

    public void TotalizadorDeTributos()
    {
        Console.WriteLine($"O total de tributos arrecadados foram de: ${Impostos}");
    }
}
