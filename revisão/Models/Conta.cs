namespace revisão.Models;

internal class Conta
{
    private static int proximoNumero = 1;
    public Conta(string titular)
    {
        Titular = titular;
        Numero = proximoNumero++;
        Saldo = 0;
    }

    public string Titular { get; set; }
    public int Numero { get; private set;}
    public double Saldo { get; set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }
    public virtual void Sacar(double valor)
    {
        ValidarTransacao(valor);
        Saldo -= valor;

    }
    public virtual void Transferir(double valor, Conta contaDestino)
    {
        ValidarTransacao(valor);
        Saldo -= valor;
        contaDestino.Depositar(valor);
        Console.WriteLine($"{Titular} fez uma transferência de ${valor} para: {contaDestino.Titular}");

    }

    protected void ValidarTransacao(double valor)
    {
        if(valor > Saldo)
        {
            Console.WriteLine("Valor insuficiente para a transação :/");
            return;
        }
    }

    public virtual void CalculoDeTributo()
    {

    }
}
