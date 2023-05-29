using Propriedades.Models;

// Pessoa p1 = new Pessoa();

// p1.Nome = "Ana";
// p1.Sobrenome = "Silva";
// p1.Idade = 20;

// p1.Apresentar();

Pessoa p1 = new Pessoa();
p1.Nome = "Ana";
p1.Sobrenome = "Silva";
p1.Idade = 20;

Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Sobrenome = "Silva";
p2.Idade = 22;

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();