namespace revisão.Models;

internal class ContaCorrente : Conta
{
    public ContaCorrente(string titular) : base(titular)
    {
        Titular = titular;
    }
}
