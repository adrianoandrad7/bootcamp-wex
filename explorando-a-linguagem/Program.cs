using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Adriano",sobrenome: "Andrade");
Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

