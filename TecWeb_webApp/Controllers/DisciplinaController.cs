using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TecWeb_webApp.Models;

namespace TecWeb_webApp.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult Index(int idAluno, string nomeAluno)
        {
            ViewBag.idAluno = idAluno;
            ViewBag.NomeAluno = nomeAluno;

            List<Disciplina> Disciplinas = new List<Disciplina>();



            Disciplinas.Add(new Disciplina(1, 1, "Tecnologia Web", "4A", "Sistemas da Informação"));
            Disciplinas.Add(new Disciplina(1, 2, "Banco de Dados", "2A", "Analise e Desenvolvimento de Sistemas"));
            Disciplinas.Add(new Disciplina(1, 3, "Banco de Dados 2", "3A", "Sistemas da Informação"));

            Disciplinas.Add(new Disciplina(2, 1, "Arquitetura da Informação", "4A", "Analise e Desenvolvimento de Sistemas"));
            Disciplinas.Add(new Disciplina(2, 2, "Engenharia de Software", "5A", "Sistemas da Informação"));
            Disciplinas.Add(new Disciplina(2, 3, "Programação BackEnd", "A1", "Analise e Desenvolvimento de Sistemas"));

            Disciplinas.Add(new Disciplina(3, 7, "Sistemas Computacionais", "2A", "Sistemas da Informação"));
            Disciplinas.Add(new Disciplina(3, 6, "Qualidade de Software", "4A", "Analise e Desenvolvimento de Sistemas"));

            Disciplinas.Add(new Disciplina(4, 9, "Algororimos e Logica de Programação", "1A", "Analise e Desenvolvimento de Sistemas"));
            Disciplinas.Add(new Disciplina(4, 8, "Gerenciamento de Projetos", "5A", "Analise e Desenvolvimento de Sistemas"));

            Disciplinas.Add(new Disciplina(4, 10, "Arquitetura da Informação", "1A", "Sistemas da Informação"));



            List<Disciplina> DisciplinasDeAluno = Disciplinas.Where(x => x.IdAluno == idAluno).ToList();

            return View(DisciplinasDeAluno);
        }
    }
}