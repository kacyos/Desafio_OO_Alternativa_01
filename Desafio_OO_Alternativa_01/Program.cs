namespace Desafio_OO_Alternativa_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Pessoa> pessoas = new List<Pessoa>();
            List<Aluno> alunos = new List<Aluno>();

           Conector.carregarDados(pessoas, alunos);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t*********************************************************************");
            Console.WriteLine($"\t\tTotal de Pessoas: {pessoas.Count()}\t\tTotal de Alunos: {alunos.Count()}");
            Console.WriteLine("\t*********************************************************************");
            alunos.ForEach(aluno => {
                
                Console.WriteLine($"\t\t Aluno: {aluno.Nome} - Cuso: {aluno.Curso.NomeCurso}");                
            });
            Console.WriteLine("\t**********************************************************************");
            Console.ResetColor();
        }
    }
}