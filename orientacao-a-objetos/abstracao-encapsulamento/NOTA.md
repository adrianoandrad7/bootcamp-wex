# Introdução a Orientação a Objetos

# Objetivo Geral

Apresentar e explorar o paradigma de programação orientado a objeto, seus usos e como é aplicado no dia a dia da programação.

## Introdução POO, Abstração e Encapsulamento

O que é POO?

A POO é um paradgma de programação, ou seja, corresponde a uma técnica de programação para um fim específico.

Dentro desta técnica, existem quatro pilares que são:

* Abstração
* Encapsulamento
* Herança
* Polimorfismo

O que é POO?

Casse: É a representação de um objeto do mundo real, ou seja, é a representação de um objeto que possui caracteristicas e comportamentos.
Objeto: É a instancia de uma classe é a implementação de uma classe.(concretização da classe).

## Tipos de paradigmas de programação

Um paragradima nada mias é do que um modelo de técnicas, estruturas e formas de solucionar um problema.

Paradigma de programação é diferente de linguagem de programação.

Uma linguagem de programação implementa um ou mais paradigmas de programação.

Paradigmas de programação:
- Programação orientada a objetos
- Programação estruturada
- Programação imperativa
- Programação procedural
- Programação orientada a eventos
- Programação lógica

## Introção a Abstração

Abstrair um obejto do mundo real para um contxto específico, considerando apenas os atributos importantes.

Ex: Carro

Atributos importantes:
- Cor
- Modelo
- Marca
- Ano
- Placa

Atributos não importantes:
- Peso
- Altura
- Largura
- Comprimento

Abstração na prática:

Classe
```csharp
namespace ExemploPOO.Models
{
    public class Carro
    {
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
    }

    public void imprimeCarro(Carro carro)
    {
        Console.WriteLine($"Cor: {carro.Cor}");
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Marca: {carro.Marca}");
        Console.WriteLine($"Ano: {carro.Ano}");
        Console.WriteLine($"Placa: {carro.Placa}");
    }
}

```

Objeto
```csharp
public void main()
{
    Carro carro = new Carro();
    carro.Cor = "Azul";
    carro.Modelo = "Uno";
    carro.Marca = "Fiat";
    carro.Ano = 2010;
    carro.Placa = "ABC-1234";
    carro.imprimeCarro(carro);
}
```

## Introdução Encapsulamento

O encapsulamento serve para proteger uma classe e definir limites para alteração de suas propriedades e métodos.

Serve para ocultar seu comportamento e expor somente o necessário.

Ex: Conta Bancária

```csharp
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
```
    
```csharp
    public void main()
    {
        ContaCorrente conta = new ContaCorrente(123, 1000);
        conta.ExibirSaldo();
        conta.Sacar(500);
        conta.ExibirSaldo();
    }
```

Neste exemplo, a classe ContaCorrente possui dois atributos, NumeroConta e Saldo, o atributo NumeroConta é público, ou seja, pode ser acessado por qualquer classe, já o atributo Saldo é privado, ou seja, só pode ser acessado pela própria classe.

## Classes Abstratas e Interfaces
