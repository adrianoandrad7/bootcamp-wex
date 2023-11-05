# Exceptions

Os recursos de manipulações de excepções da linguagem C# ajudam você a lidar com quaisquer situações excepcionais ou inesperadas que ocorram quando um programa for executado.

## Tratando uma exceção

```csharp
    try // tente
    {
        string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }catch (Exception ex) // obter
    {
        Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
    }
```

Utilizando try catch ele vai tratar a execeção e continuar a execução do programa. Ao contrario ele vai parar a execução do programa.

## Exceção genérica e específica

```csharp
    try // tente
    {
        string[] linhas = File.ReadAllLines("Arquivos/Pasta01/arquivo_Leitura.txt");

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }catch(FileNotFoundException ex)
    {
        System.Console.WriteLine($"O correu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
    }catch(DirectoryNotFoundException ex)
    {
        System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
    }catch (Exception ex) // obter
    {
        Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
    }
```

Como podemos ver no exemplo acima, podemos tratar exceções especificas e genéricas.

## Entendendo o bloco finally


```csharp   
    try // tente
    {
        string[] linhas = File.ReadAllLines("Arquivos/Pasta01/arquivoLeitura.txt");

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    }
    catch(FileNotFoundException ex)
    {
        Console.WriteLine($"O correu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
    }
    catch(DirectoryNotFoundException ex)
    {
        Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
    }
    catch (Exception ex) // obter
    {
        Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Será executado sempre");
    }
```

O bloco finally sempre será executado, independente se ocorreu uma exceção ou não. Pode ser utilizado para fechar conexões com banco de dados, fechar conexões com arquivos, etc.

## Usando o Throw

```csharp	
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            try
            {
                Metodo3();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceção tratada. {ex.Message}");
            }
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
```

Com o throw podemos lançar uma exceção, e tratar ela em outro lugar. No exemplo acima, o método 4 lança uma exceção, e o método 2 trata ela.
    
## Introdução a Queue (Fila)

Exemplo em uma fila onde o primeiro a entrar é o primeiro a sair. Também conhecido como FIFO (First In First Out).

```csharp
    Queue<string> fila = new Queue<string>();

    fila.Enqueue("Fulano");
    fila.Enqueue("Sicrano");
    fila.Enqueue("Beltrano");

    foreach (string pessoa in fila)
    {
        Console.WriteLine(pessoa);
    }

    Console.WriteLine($"Primeiro da fila: {fila.Peek()}"); // Peek retorna o primeiro da fila, mas não remove da fila.

    Console.WriteLine($"Primeiro da fila: {fila.Dequeue()}"); // Dequeue retorna o primeiro da fila, e remove da fila.

    Console.WriteLine($"Primeiro da fila: {fila.Peek()}"); 

    foreach (string pessoa in fila)
    {
        Console.WriteLine(pessoa);
    }
```

## Introdução a Stack (Pilha) - Coleção LIFO

Stack (Pilha) Ultimo a entrar é o primeiro a sair. Também conhecido como LIFO (Last In First Out).

```csharp
    Stack<string> pilha = new Stack<string>();

    pilha.Push("Fulano");
    pilha.Push("Sicrano");
    pilha.Push("Beltrano");

    foreach (string pessoa in pilha)
    {
        Console.WriteLine(pessoa);
    }

    Console.WriteLine($"Primeiro da fila: {pilha.Peek()}");

    Console.WriteLine($"Primeiro da fila: {pilha.Pop()}");

    Console.WriteLine($"Primeiro da fila: {pilha.Peek()}");

    foreach (string pessoa in pilha)
    {
        Console.WriteLine(pessoa);
    }
```

## Introdução a Dictionary (Dicionário) - Coleção de chave-valor

Um dictonary é uma cloleção de chave-valor para armazenar valores únicos sem uma ordem específica. 

```csharp
    Dictionary<string, string> estados = new Dictionary<string, string>();

    estados.Add("SP", "São Paulo");
    estados.Add("BA", "Bahia");
    estados.Add("MG", "Minas Gerais");

    foreach (var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    }
```
