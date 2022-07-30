using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb_webApp.Models
{
    public class Aluno    {

        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(int idaluno, string nome, int ra, DateTime datanasc)
        {
            IdAluno = idaluno;
            Nome = nome;
            RA = ra;
            DataNascimento = datanasc;
        }
    }
}