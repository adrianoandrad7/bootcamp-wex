using System.Threading.Channels;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo  { get; set; }
    
        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            { 
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }else
                Console.WriteLine("Valor desejado é maior que o saldo disponível");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é: {Saldo}");
        }
    } 
}

