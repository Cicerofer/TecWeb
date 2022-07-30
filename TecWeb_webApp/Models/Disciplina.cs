using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecWeb_webApp.Models
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Semestre { get; set; }
        public string Curso { get; set; }

        public Disciplina(int iddisciplina, int idaluno, string nome,  string semestre, string curso)
        {
            IdDisciplina = iddisciplina;
            IdAluno = idaluno;
            Nome = nome;
            Semestre = semestre;
            Curso = curso;
        }
    }
}