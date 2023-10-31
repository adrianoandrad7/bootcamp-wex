using ExemploExplorando.Models;
using System.Globalization;

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

