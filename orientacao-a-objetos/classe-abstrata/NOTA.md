## Classe Abstrata

Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.

Você pode implementar métodos ou deixá-los a cargo de quem herdar.

* Conta
- Saldo : double
+ Creditar() <<abstract>>
+ ExibirSaldo() 

* ContaCorrente
- Tarifa : double
+ Creditar()

Ela não pode ser instanciada, mas pode ser herdada por outras classes.

```csharp
    namespace ExemploPOO.Models
    {
        public abstract class Conta
        {
            public double Saldo { get; set; }

            public abstract void Creditar(double valor);

            public void ExibirSaldo()
            {
                Console.WriteLine("Saldo: " + Saldo);
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public class ContaCorrente : Conta
        {
            public double Tarifa { get; set; }

            public override void Creditar(double valor)
            {
                Saldo += valor - Tarifa;
            }
        }
    }
```

```csharp
    namespace ExemploPOO
    {
        class Program
        {
            static void Main(string[] args)
            {
                ContaCorrente cc = new ContaCorrente();
                cc.Tarifa = 10;
                cc.Creditar(100);
                cc.ExibirSaldo();
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public abstract class Conta
        {
            public double Saldo { get; set; }

            public abstract void Creditar(double valor);

            public void ExibirSaldo()
            {
                Console.WriteLine("Saldo: " + Saldo);
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public class ContaCorrente : Conta
        {
            public double Tarifa { get; set; }

            public override void Creditar(double valor)
            {
                Saldo += valor - Tarifa;
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public class ContaPoupanca : Conta
        {
            public double Juros { get; set; }

            public override void Creditar(double valor)
            {
                Saldo += valor + Juros;
            }
        }
    }
```

```csharp
    namespace ExemploPOO
    {
        class Program
        {
            static void Main(string[] args)
            {
                ContaCorrente cc = new ContaCorrente();
                cc.Tarifa = 10;
                cc.Creditar(100);
                cc.ExibirSaldo();

                ContaPoupanca cp = new ContaPoupanca();
                cp.Juros = 5;
                cp.Creditar(100);
                cp.ExibirSaldo();
            }
        }
    }
```

Você observou que a classe Conta não possui um método Creditar() implementado, pois cada tipo de conta possui uma regra diferente para creditar um valor. Desta forma, a classe Conta é uma classe abstrata e o método Creditar() é um método abstrato, pois não possui implementação.

Sendo assim você não pode instanciar um objeto do tipo Conta, mas pode instanciar objetos do tipo ContaCorrente e ContaPoupanca.

Ela serve somente como modelo para ser herdada por outras classes.

## Construtor por herança

```csharp

public class Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }
    public int Idade { get; set; }
}

public class PessoaFisica : Pessoa
{
    public PessoaFisica(string nome, string cpf) : base(nome)
    {
        CPF = cpf;
    }
    public string CPF { get; set; }
}

public class PessoaJuridica : Pessoa
{
    public PessoaJuridica(string nome, string cnpj) : base(nome)
    {
        CNPJ = cnpj;
    }
    public string CNPJ { get; set; }
}

```

Observedo o código acima, você pode perceber que a classe Pessoa possui um construtor que recebe o nome da pessoa, e as classes PessoaFisica e PessoaJuridica herdam de Pessoa e possuem um construtor que recebe o nome e o CPF ou CNPJ, respectivamente.

O que te obriga a chamar o construtor da classe base, passando o nome da pessoa. Isso é feito através da palavra reservada base.

## Classe Selada

Uma classe selada tem como objetivo de impedir que outras classses façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada.

Também existem métodos e propriedades seladas.

Classes:
Pessoa - Aluno - Professor <<selada>> X Diretor

Apartir da classe Professor, não é possível criar uma classe derivada.

Metodo selado

* Professor
+ Salario : double
+ Apresentar() <<Selado>>

Direto (herda de professor)
Não pode sobrescrever o método Apresentar()

## Classe e Método selado na prática

```csharp
public sealed class Professor : Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    
    public double Salario { get; set; }
}
```
Neste exemplo, a classe Professor é selada, ou seja, nenhuma classe pode herdar dela.

Método
```csharp
public sealed class Professor : Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    
    public double Salario { get; set; }
    
    public sealed override void Apresentar()
    {
        Console.WriteLine("Olá, eu sou o professor " + Nome);
    }
}
```

Você pode observar que a classe Professor é selada, ou seja, nenhuma classe pode herdar dela.

## Classe Object

A classe System.Object é a mãe de todas as classes do .NET, ou seja, todas as classes herdam dela.

Todas as classes derivam, direta ou indiretamente, da classe Object, e ela tem como objetivo prover serviçõs de baixo nível para suas classes filhas.

A classe Object possui os seguintes métodos:

Equals() - Determina se o objeto especificado é igual ao objeto atual.
GetHashCode() - Serve para retornar um código hash para o objeto.
GetType() - Obtém o Type da instância atual.
ToString() - Retorna uma cadeia de caracteres que representa o objeto atual.
Finalize() - Permite que um objeto tente liberar recursos e executar outras operações de limpeza antes que ele seja recuperado pela coleta de lixo.
MemberwiseClone() - Cria uma cópia superficial do Object atual.
ReferenceEquals() - Determina se a instância atual é a mesma instância que um outro objeto especificado.



