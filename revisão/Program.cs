using revisão.Models;

TotalizadorDeContas totalizador = new TotalizadorDeContas();

Conta contaTheo = new ContaCorrente("Theo");
totalizador.AdicionarConta(contaTheo);

Conta contaLuffy = new ContaPoupanca("Luffy");
totalizador.AdicionarConta(contaLuffy);

Conta contaNami = new ContaPoupanca("Nami");
totalizador.AdicionarConta(contaNami);

contaNami.Depositar(9000);
contaNami.Sacar(3000);

contaTheo.Depositar(500);
contaTheo.Transferir(300, contaLuffy);

SeguroDeVida seguro = new SeguroDeVida("Theo");
seguro.Depositar(500);
ContaInvestimento investimento = new ContaInvestimento("Theo");
seguro.Depositar(500);


Console.WriteLine(contaTheo.Numero);
Console.WriteLine(contaNami.Numero);
Console.WriteLine(contaTheo.Saldo);

double totalSaldo = totalizador.CalcularTotalSaldo();
seguro.CalculoDeTributo();
seguro.TotalizadorDeTributos();
investimento.CalculoDeTributo();
investimento.TotalizadorDeTributos();
Console.WriteLine(totalSaldo);