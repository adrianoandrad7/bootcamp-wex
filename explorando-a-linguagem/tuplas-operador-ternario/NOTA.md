# Tuplas

Tuplas fornece sintaxe concisa para agrupar vários elementos de dados em uma estrutura leve. 

```csharp
    (int, string, string, decimal) tupla = (1, "Adriano", "Andrade", 1.73M);

    System.Console.WriteLine($"Id: {tupla.Item1}");
    System.Console.WriteLine($"Nome: {tupla.Item2}");
    System.Console.WriteLine($"Sobrenome {tupla.Item3}");
    System.Console.WriteLine($"Altura {tupla.Item4}");
```

Tupla são uma alternativa para criar classes com propriedades, e são mais leves.

## Tuplas em métodos

Tuplas podem ser utilizadas como retorno de métodos.

```csharp
public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
{
    try
    {
        string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count()); 
        }
    catch (Exception)
    {
        return (false, new string[0], 0);
    }
}    
```

# Descartes

```csharp
    LeituraArquivo arquivo = new LeituraArquivo();

    var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

    if(sucesso)
    {
        foreach (var linha in linhasArquivo)
        {
            Console.WriteLine(linha);
        }
    }else
    {
        Console.WriteLine("Não foi possível ler o arquivo");
    }
```
O uso do _ é para descartar sendo util quando não se deseja utilizar o valor da variável.

## Desconstrutor

Ele serve para desmembrar um objeto. Ele é usado em tuplas e permite que você desmembre um objeto em variáveis.

```csharp
    public void Deconstruct(out string nome, out string sobrenome)
    {
        nome = Nome;
        sobrenome = Sobrenome;
    }
```

```csharp
    Pessoa p1 = new Pessoa("Adriano", "Andrade");

    (string nome, string sobrenome) = p1;

    Console.WriteLine($"{nome} {sobrenome}");
```

## If Ternário

```csharp
    int idade = 18;
    string resultado = (idade < 18) ? "Menor de idade" : (idade == 18) ? "Menor de idade" : "Maior de idade";
```
```csharp
    bool isTrue = true;
    string message = isTrue ? "Verdadeiro" : "Falso";
```

````csharp
    int x = 15;
    string result = (x % 2 == 0) ? "Par" : "Ímpar";
````