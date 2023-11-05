using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

List<Venda>? listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

if (listaVenda != null)
    foreach (Venda venda in listaVenda)
    {
        Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                          $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
    }

// List<Venda> listaVendas = new List<Venda>();
//
// DateTime dataAtual = DateTime.Now;
// Venda v1 = new Venda(1, "Material de escritório", 25.00M,dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
//
// listaVendas.Add(v1);
// listaVendas.Add(v2);
//
// string serializado = JsonConvert.SerializeObject(listaVendas, Newtonsoft.Json.Formatting.Indented);
//
// File.WriteAllText("Arquivos/vendas.json", serializado);
//
// Console.WriteLine(serializado);

// int numero = 11;
// bool ehPar = false;

// ehPar = numero % 2 == 0;

// System.Console.WriteLine($"O número {numero} é: " + (ehPar ? "par" : "ímpar"));


// Pessoa p1 = new Pessoa("Leonardo", "Buta");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


// (int, string, string, decimal) tupla = (1, "Adriano", "Andrade", 1.73M);

// ValueTuple<int, string, decimal> outroExemplo = (1, "Leonardo", "Buta", 1.80M);
// var outroExemploTuplaCreate = tupla.Create(1, "Adriano", "Andrade", 1.73M);

// System.Console.WriteLine($"Id: {tupla.Item1}");
// System.Console.WriteLine($"Nome: {tupla.Item2}");
// System.Console.WriteLine($"Sobrenome {tupla.Item3}");
// System.Console.WriteLine($"Altura {tupla.Item4}");


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }


//new ExemploExcecao().Metodo1();


// try // tente
// {
//     string[] linhas = File.ReadAllLines("Arquivos/Pasta01/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"O correu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch (Exception ex) // obter
// {
//     Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Será executado sempre");
// }


//using System.Globalization;
// string dataString = "2022-12-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     System.Console.WriteLine($"Conversão com sucesso data: {data}");
// }else
// {
//     System.Console.WriteLine($"{dataString} não é uma data válida");
// }


//System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C4}");
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("in-US")));

// double porcentagem = .3421;
// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));


// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// System.Console.WriteLine(resultado);



// Pessoa p1 = new Pessoa(nome: "Adriano", sobrenome: "Andrade Do Nascimento");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

