using System.Runtime.CompilerServices;
using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


//Lista funciona como um array interno
System.Console.WriteLine("Percorrendo a lista com o for");
for (int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

System.Console.WriteLine("Percorrendo a lista com o foreach");
foreach (string item in listaString)
{
    System.Console.WriteLine($"Estado: {item}");
}

// Vantagens na lista voce não precisa se preocupar com o tamanho e redimensionamento - menos complexidade mais indicado

System.Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("NG");

System.Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("RJ");

System.Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 1;
// arrayInteiros[1] = 2;
// arrayInteiros[2] = 3;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // redimenciona o array fazendo uma copia por referência
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length); // nesse caso ele faz uma copia para outro array mantem seu tamanho
 
// System.Console.WriteLine("Percorrendo o array com o for");
// for(int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine($"Array na posição {i} = {arrayInteiros[i]}");
// }

// System.Console.WriteLine("Percorrendo o array com o foreach");
// foreach(int inteiro in arrayInteiros)
// {
//     System.Console.WriteLine($"{inteiro}");
// }

// Instânciando uma "Pessoa"

/*Pessoa pessoa1 = new Pessoa(); // Cria uma instância.
pessoa1.Nome = "Adriano"; // seta na propriedade nome
pessoa1.Idade = 24; // seta na propriedade idade
pessoa1.Apresentar();
/*
//     *Convenções Cases
//     camelCase PascalCase
//     snake_case spinal-case
//     * classe PascalCase
//     * atributos PascalCase
//     * metodos PascalCase
//     * variavel camelCase
// */

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// System.Console.WriteLine(apresentacao);
// System.Console.WriteLine("Valor da variável quantidade: " + quantidade);
// System.Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// System.Console.WriteLine("Valor da variável preço: " + preco);
// System.Console.WriteLine("Valor da variável condicao: " + condicao);

// // Manipulando variáveis
// // O tipo Date Time

// DateTime dataAtual = DateTime.Now.AddDays(5);
// System.Console.WriteLine("Data Atual: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));

// int quantidadeEmEstoque = 200;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// // If Alinhadado

// if(quantidadeCompra == 0)
//     System.Console.WriteLine("Venda inválida.");
// else if(possivelVenda)
//     System.Console.WriteLine("Venda realizada.");
// else
//     System.Console.WriteLine("Desculpe: Não temos a quantidade desejada em estoque.");
// Aprendendo o Switch Case

// System.Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch(letra) // Mais adequado para esse tipo de caso
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         System.Console.WriteLine("Volgal");
//         break;
//     default:
//         System.Console.WriteLine("Não é uma volgal");
//         break;
// }

// string letra = Console.ReadLine();

// string vogal = letra switch 
// {
//     "a" => "vogal",
//     "e" => "vogal",
//     "i" => "vogal",
//     "o" => "vogal",
//     "u" => "vogal",
//     _ =>"não é volgal"
// };

// Operadores Lógicos

/*
    Operador OR(Pipe, ||)
    Problema Maior que 18 anos Sim || Não
    Entra Liberada
    Possui autorização do responsável
*/

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//     System.Console.WriteLine("Entrada liberada");
// else
//     System.Console.WriteLine("Entrada não liberada");

// Introdução ao operador AND (&&)

/*
    Possui presença minima sim? não?
    não -> reprovado 
    sim -> possui média igual ou maior que x ?
    sim -> aprovado
    não -> reprovado
*/

// bool possuiPresencaMinima = false;
// double media = 6.5;

// if(possuiPresencaMinima && media >= 7)
//     System.Console.WriteLine("Aprovado");
// else
//     System.Console.WriteLine("Reprovado");

// Introdução ao Operador NOT (!)

/*
    Choveu
    sim ? vou pedalar outro dia
    não ? -> está tarde? 
    sim ? vou pedalar outro dia
    não ? vou pedalar 
*/

// bool choveu = true;
// bool estaTarde = false;

// if(!choveu && !estaTarde)
//     System.Console.WriteLine("Vou pedalar");
// else    
//     System.Console.WriteLine("Vou pedalar outro dia");

// Operadores aritméticos e a classe Math

/*Arithmetic Operators
    + -> addition,
    - -> subtraction,
    * -> multiplication,
    / -> division,
    % -> modulus,
    ++ -> increment,
    -- -> decrement.
*/

// Calculadora calc = new Calculadora();
// calc.Somar(10, 90);
// calc.Subtrair(90, 10);
// calc.Multiplicar(20, 20);
// calc.Divisao(10, 2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numero = 10;

// System.Console.WriteLine(numero);

// System.Console.WriteLine($"Incrementando o 10");
// //numero = numero + 1;
// numero ++;
// System.Console.WriteLine(numero);

// System.Console.WriteLine(numero);

// System.Console.WriteLine($"Decrementando o {numero}");
// //numero = numero + 1;
// numero --;
// System.Console.WriteLine(numero);

// Estruturas de repetição

/*
    Tabuada 
    1 - contador é menor ou igual a 10?
    2 - sim -> x * contador -> contador++
    3 - não -> fim
    loop enquanto sum retorna no passo 1
*/

// Introdução ao for 
// Tabuada de 10

// int numero = 10;

// for(int i = 0; i <= numero; i++)
// {
//     System.Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

//Debugando o for
//Introdução ao while

// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     System.Console.WriteLine($"{contador + 1} Execução {numero} * {contador} = {numero * contador}");
//     contador ++;

//     if(contador == 6)
//         break;
// }

// Debugando o While
// Interrompendo o fluxo de execução utilizando break

//Introdução ao Do While


// int soma = 0, numero = 0;

// do{
//     Console.WriteLine($"Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine()); 
//     soma += numero;
// }while(numero != 0);

// Debugando o do while

// Construindo um menu interativo

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
            
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// System.Console.WriteLine("O programa se encerrou");

// // while executa primeiro sua condição do while executa seu codigo primeiro independente e depois executa a condição








