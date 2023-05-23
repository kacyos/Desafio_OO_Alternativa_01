using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_OO_Alternativa_01
{
    internal class Conector
    {
        private static List<string> dados = DataBase.realizarLeituraDoArquivo("dados.dat");
        /// <summary>
        /// Método da Classe Conector, cria Alunos, Pessoas e Cursos e popula a lista de pessoas e alunos
        /// </summary>
        /// <param name="listaDePessoas"></param>
        /// <param name="listaDeAlunos"></param>
        public static void carregarDados(List<Pessoa> listaDePessoas, List<Aluno> listaDeAlunos)
        {
            Pessoa pessoa;
            Aluno aluno;
            Curso curso;

            dados.ForEach(item => {

                if (item.StartsWith("Z"))
                {
                  string[] vetorPessoa = item.Split("-");
                  pessoa = new Pessoa(vetorPessoa[1], vetorPessoa[2], vetorPessoa[3], vetorPessoa[4], vetorPessoa[5]);
                  listaDePessoas.Add(pessoa);
                } else if(item.StartsWith("Y"))
                {

                    string[] vetorCurso = item.Split("-");
                    curso = new Curso(vetorCurso[2], vetorCurso[3]);
                    aluno = new Aluno(listaDePessoas.Last().Nome, listaDePessoas.Last().Telefone, listaDePessoas.Last().Cidade, listaDePessoas.Last().Rg, listaDePessoas.Last().Cpf, vetorCurso[1] , curso);
                    listaDeAlunos.Add(aluno);
                }               
            
            });           
        }
              
    }
}
