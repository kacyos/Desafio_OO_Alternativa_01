using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_OO_Alternativa_01
{
    internal class Aluno : Pessoa
    {
        private string _matricula;
        private Curso _curso;

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, Curso curso) : base(nome, telefone, cidade, rg, cpf)
        {
            _matricula = matricula;
            _curso = curso;
        }

        public string Matricula { get => _matricula; set => _matricula = value; }
        public Curso Curso { get => _curso; set => _curso = value; }       
    }
}
