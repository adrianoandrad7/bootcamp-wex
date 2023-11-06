# Heraça e Polimosfismo

## Herança

A herança nos permite reutilizar atributos, métodos e comportamentos de uma classe em outras classes

Serve para agrupar obejtos que são do mesmo tipo, porém com características diferentes.

Exemplo:

Aluno
+ nome
+ idade
+ nota
+ Apresentar()

Professor
+ nome
+ idade
+ salario
+ Apresentar()

Veja que as classes Aluno e Professor possuem atributos em comum, como nome e idade. Então podemos criar uma classe Pessoa que possui esses atributos e fazer com que Aluno e Professor herdem de Pessoa.

- Pessoa
    + nome
    + idade
    + Apresentar()
- Aluno (herda de Pessoa)
    + nota
- Professor (herda de Pessoa)
    + salario

Cuida com a herança, exemplo Pessoa e Carro. Não faz sentido Carro herdar de Pessoa, pois Carro não é uma Pessoa. Mesmo que tenha alguns atributos em comum, não faz sentido.


```csharp
    namespace ExemploPOO.Models
    {
        public class Aluno : Pessoa
        {
            public double Nota { get; set; }
        }
    }
```
```csharp
    namespace ExemploPOO.Models
    {
        public class Professor : Pessoa
        {
            public decimal Salario { get; set; }
        }
    }
```

```csharp
    Aluno a1 = new Aluno();
    a1.Nome = "Adriano";
    a1.Idade = 23;
    a1.Email = "adriano@gmail.com";
    a1.Nota = 85;
    a1.Apresentar();

    Professor p1 = new Professor();
    p1.Nome = "Fernanda";
    p1.Idade = 30;
    p1.Email = "fernanda@gmail.com";
    p1.Salario = 2500;
    p1.Apresentar();
```	

Como podemos ver, a classe Aluno e Professor herdam de Pessoa, então podemos acessar os atributos Nome, Idade e Email diretamente.

# Observação

* No C# não existe herança múltipla, ou seja, uma classe não pode herdar de duas ou mais classes.
* Não é recomendado criar muitas classes herdando de uma mesma classe, pois pode gerar um acoplamento muito grande entre as classes.

## Polimorfismo

O polimorfismo vem do grego e significa "muitas formas". 
Com o polimorfismo, podemos sobrescrever métodos das classes filhas para que se comportrm de maneira diferente e ter sua própria implementação.	

Exemplo:

```csharp
    namespace ExemploPOO.Models
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Email { get; set; }

            public virtual void Apresentar()
            {
                Console.WriteLine("Olá, eu sou uma pessoa e meu nome é " + Nome);
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public class Aluno : Pessoa
        {
            public double Nota { get; set; }

            public override void Apresentar()
            {
                Console.WriteLine("Olá, eu sou um aluno e meu nome é " + Nome);
            }
        }
    }
```

```csharp
    namespace ExemploPOO.Models
    {
        public class Professor : Pessoa
        {
            public decimal Salario { get; set; }

            public override void Apresentar()
            {
                Console.WriteLine("Olá, eu sou um professor e meu nome é " + Nome);
            }
        }
    }
```

Como vimos nos exemplos acima, a classe Pessoa possui um método Apresentar() que é sobrescrito nas classes Aluno e Professor. Desta forma, quando chamamos o método Apresentar() de um objeto do tipo Aluno ou Professor, será executado o método Apresentar() da classe correspondente com comportamento diferentes.

##Considerações finais

### Polimorfismo em tempo de compilação (Overload/Early Binding)

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

Mesmo método com assinaturas diferentes e não depende de herança.

### Polimorfismo em tempo de execução (Override/Late Binding)

```csharp
public class Pessoa
{
    public virtual void Apresentar()
    {
        Console.WriteLine("Olá, eu sou uma pessoa");
    }
}

public class Aluno : Pessoa
{
    public override void Apresentar()
    {
        Console.WriteLine("Olá, eu sou um aluno");
    }
}
```	

Já nesse exemplo temos mesmo método com assinaturas iguais e depende de herança.





