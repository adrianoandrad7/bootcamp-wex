# Manipulando Valores

## Concatenação de strings

Podemos formatar valores em diversas representações. Essa formatação de valores é conhecida por concatenação ou interpolação.

## Concatenando strings

```C#
    string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
```

## Interpolação de string '$'

```C#
    string texto = $"N° {count} - {Alunos[count].NomeCompleto}";
```

* Melhor opção para concatenar strings, mais legível;

## Concatenação de Valores

```C#

    string numero1 = "10";
    int numero2 = 20;
    string resultado = numero1 + numero2;
    System.Console.WriteLine(resultado); 
```
* Retorna string 1020 pois o valor de numero1 é uma string e tem preferência na conversão cast implícita

## Formatando valores monetários

```C#
    decimal valorMonetario = 82.40M;
    Console.WriteLine(valorMonetario); // 82.40
    Console.WriteLine($"{valorMonetario:C}"); // R$ 82,40 representa valor monetário
```

## Alterando a localização do sistema

```C#
    CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
    decimal valorMonetario = 82.40M;
    Console.WriteLine(valorMonetario); // 82.40
    Console.WriteLine($"{valorMonetario:C}"); // $82.40 representa valor monetário
```

## Alterando a localização da cultura

```C#
    Console.WriteLine($"{valorMonetario:C4}"); // formato com 4 casas decimais
    Console.WriteLine(valorMonetario.ToString("N2")); // formato com 2 casas decimais
```

## Formatação Personalizadas

```C#
    decimal valorMonetario = 82.40M;
    Console.WriteLine(valorMonetario.ToString("C", new CultureInfo("en-US"))); // $82.40 representa valor monetário
    Console.WriteLine(valorMonetario.ToString("C", new CultureInfo("pt-BR"))); // R$ 82,40 representa valor monetário
```

## Representando Porcentagem

```C#
    double porcentagem = .3421;
    System.Console.WriteLine(porcentagem.ToString("P")); // 34,21%
    int numero = 123456;
    System.Console.WriteLine(numero.ToString("##-##-##")); // 12-34-56
```	

## Formatando o tipo DateTime

```C#
    DateTime data = DateTime.Now;
    System.Console.WriteLine(data);
    System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // 22/07/2021 10:30
    System.Console.WriteLine(data.ToShortDateString()); // 22/07/2021
    System.Console.WriteLine(data.ToShortTimeString()); // 10:30
```

## DateTime com TryParse

```C#
string dataString = "2022-12-17 18:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data); // Se a conversão for bem sucedida, a variável data será preenchida com o valor convertido se não, será preenchida com o valor padrão do tipo DateTime
System.Console.WriteLine(data);
```
## Validando o retorno do TryParse

```C#  
    string dataString = "2022-12-17 18:00";

    bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None, out DateTime data);

    if(sucesso)
    {
        System.Console.WriteLine($"Conversão com sucesso data: {data}");
    }else
    {
        System.Console.WriteLine($"{dataString} não é uma data válida");
    }
```
