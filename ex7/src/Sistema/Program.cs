using Exercicio;

Console.WriteLine("Exercício 7");
Console.WriteLine("-----------------------");

try
{
    Exame exame1 = new Exame();
    exame1.NomeDoAluno = "Alex";
    exame1.NotaDoAluno = 10;

    Exame exame2 = new Exame();
    exame2.NomeDoAluno = "B";
    exame2.NotaDoAluno = 20;

    Classe sala1 = new Classe();
    sala1.NomeDaClasse = "1infoa";

    var exames = new List<Exame> { exame1, exame2 };

    sala1.AdicionarExame(exames);
    sala1.RetornaMenorNota();
    
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}