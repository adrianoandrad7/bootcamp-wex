# Interfaces

Uma interface é um contrato que pode ser implementado por uma classe.

É como se fosse um classe abstrata, podemos definir métodos e propriedades, mas não podemos implementá-los.

Assim como uma classe abstrata, uma interface não pode ser instanciada.

<<Interface>>
* ICalculadora
+ somar()
+ subtrair()
+ multiplicar()
+ dividir

Herdam  de ICalculadora

* CalculadoraComum
+ somar()
+ subtrair()
+ multiplicar()
+ dividir()

* CalculadoraCientifica
+ somar()
+ subtrair()
+ multiplicar()
+ dividir()

## Interface na prática

```csharp
public interface ICalculadora
{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2);
}

public class CalculadoraComum : ICalculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}
```	

Como podemos ver, a interface é um contrato que a classe deve implementar.

## Método padrão na interface

```csharp
public interface ICalculadora
{
    int Somar(int num1, int num2);
    int Subtrair(int num1, int num2);
    int Multiplicar(int num1, int num2);
    int Dividir(int num1, int num2)
    {
        return num1 / num2;
    }
}

public class CalculadoraComum : ICalculadora
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
}
```

Assim como nas classes abstratas, podemos definir métodos padrões na interface. Neste exemplo, o método Dividir() é padrão, ou seja, não é obrigatório implementá-lo na classe que implementa a interface.