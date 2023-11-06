namespace ExemploPOO.Models;

public abstract class Conta
{
    protected decimal Saldo; // protect poder alterado pelas suas classes filhas
    public abstract void Creditar(decimal valor);

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é: {Saldo}" );
    }
}