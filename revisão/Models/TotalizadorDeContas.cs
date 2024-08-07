namespace revisão.Models;

internal class TotalizadorDeContas
{
    private List<Conta> contas;
    public double Total = 0;
    public TotalizadorDeContas()
    {
        contas = new List<Conta>();
    }

    public void AdicionarConta(Conta conta)
    {
        contas.Add(conta);
    }

    public double CalcularTotalSaldo()
    {
        return contas.Sum(conta => conta.Saldo);
    }
}
