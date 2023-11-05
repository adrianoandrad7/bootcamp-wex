# Gerenciador de pacotes

## O que é um pacote?

Um pacote é um conjunto de códigos úteis, que possibilita o compartilhamento e reuso do código.

## Gerenciador de pacotes

Nuget é um gerenciador de pacotes, que permite desenvolvedores compartilhar códigos e bibliotecas.

## Explorando o Nuget

Acess: nuget.org

Exemplos: 

[Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)
[Serilog](https://www.nuget.org/packages/Serilog/)
[Azure.Storage.Blobs](https://www.nuget.org/packages/Azure.Storage.Blobs/)

Os pacotes podem ser instalados via linha de comando ou via interface gráfica. Eles são importantes para o desenvolvimento de aplicações, pois permitem o reuso de código e a utilização de bibliotecas de terceiros.

Exemplo de instalação via linha de comando:

```bash
dotnet add package Newtonsoft.Json
```


## Serialização de dados

O que é serialização e deserialização de dados?

O processo de serializar consiste em tranformar objetos em um fluxo de bytes para seu armazenamento ou transmissão. Já o processo de deserializar consiste em transformar um fluxo de bytes em objetos.

https://docs.microsoft.com/pt-br/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0

## Serialização de dados
#### JSON

JavaScript Object Notation (JSON) é um formato de texto que segue a sintaxe do javascript, muito usado para troca de dados entre aplicações.

https://developer.mozilla.org/pt-BR/docs/Learn/JavaScript/Objects/JSON

Mesmo em linguagens diferentes, o JSON é interpretado da mesma forma.

.Net Core --> Json <-- Java

Exemplo de JSON:

´´´json
{
    "nome": "João",
    "idade": 30,
    "filhos": [
        {
            "nome": "Maria",
            "idade": 5
        },
        {
            "nome": "José",
            "idade": 8
        }
    ]
}


## Serialização na prática

```csharp
    using ExemploExplorando.Models;
    using Newtonsoft.Json;

    Venda v1 = new Venda(1, "Material de escritório", 25.00M);

    string serializado = JsonConvert.SerializeObject(v1, Newtonsoft.Json.Formatting.Indented);

    System.Console.WriteLine(serializado);
```

Como no exemplo a cima é possível serializar um objeto em JSON, utilizando a biblioteca Newtonsoft.Json. É muito comum a utilização de JSON para troca de dados entre aplicações.

## Escrevendo em um arquivo Json

````csharp
    Venda v1 = new Venda(1, "Material de escritório", 25.00M);

    string serializado = JsonConvert.SerializeObject(v1, Newtonsoft.Json.Formatting.Indented);

    File.WriteAllText("Arquivos/vendas.json", serializado);
````

Com o método WriteAllText da classe File, é possível escrever um arquivo com o conteúdo serializado.

## Serializando uma coleção

````csharp
    List<Venda> vendas = new List<Venda>();

    vendas.Add(new Venda(1, "Material de escritório", 25.00M));
    vendas.Add(new Venda(2, "Material de limpeza", 100.00M));
    vendas.Add(new Venda(3, "Material de informática", 250.00M));

    string serializado = JsonConvert.SerializeObject(vendas, Newtonsoft.Json.Formatting.Indented);

    File.WriteAllText("Arquivos/vendas.json", serializado);
````
É possível serializar uma coleção de objetos, como no exemplo a cima.

## Deserializando um objeto

Se você precisa ler um arquivo JSON e transformá-lo em um objeto, é possível utilizar o método ReadAllText da classe File, para ler o conteúdo do arquivo e o método DeserializeObject da classe JsonConvert para deserializar o conteúdo.

````csharp

    string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

    List<Venda>? listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

    if (listaVenda != null)
        foreach (Venda venda in listaVenda)
        {
            Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                            $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
        }
````

## Atributos [JsonProperty]

Atributos são usados para adicionar metadados ao código. Eles são representados por colchetes e podem ser colocados em classes, métodos, propriedades, parâmetros, etc.

````csharp
using Newtonsoft.Json;

public class Venda{

    public int Id { get; set; }

    [JsonProperty("Nome_Produto")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
}
````

Com esse atributo podemos resolver o problema de serialização de propriedades com nomes diferentes.