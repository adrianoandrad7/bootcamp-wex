using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string? Nome { get; set; }
        public List<Pessoa>? Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos?.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos?.Count ?? 0;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos?.Remove(aluno) ?? false;
        }

        public void ListarAlunos()
        {
            if (Nome != null)
            {
                Console.WriteLine($"Alunos do curso de {Nome}");
            }

            if (Alunos != null)
            {
                for (int count = 0; count < Alunos.Count; count++)
                {
                    string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                    Console.WriteLine(texto);
                }
            }
        }
    }
}