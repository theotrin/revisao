namespace revisão.Models;

internal class ContaPoupanca : Conta
{
    public ContaPoupanca(string titular) : base(titular)
    {
        Titular = titular;
    }

    public override void Sacar(double valor)
    {
        base.Sacar(valor);
        Saldo -= 0.10;
    }
}
