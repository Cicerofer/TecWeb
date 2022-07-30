using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TecWeb_webApp.Models;

namespace TecWeb_webApp.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            List<Aluno> Alunos = new List<Aluno>();

            Alunos.Add(new Aluno(1, "Pedro", 123456, Convert.ToDateTime("23/02/2010")));
            Alunos.Add(new Aluno(2, "Manuel", 112233, Convert.ToDateTime("12/02/2000")));
            Alunos.Add(new Aluno(3, "Rafael", 098767, Convert.ToDateTime("09/04/2007")));
            Alunos.Add(new Aluno(4, "Lucas", 167654, Convert.ToDateTime("06/04/1996")));
            Alunos.Add(new Aluno(5, "Victor", 234567, Convert.ToDateTime("15/04/2001")));
            Alunos.Add(new Aluno(6, "João", 345678, Convert.ToDateTime("01/03/2016")));
            Alunos.Add(new Aluno(7, "Marcos", 789089, Convert.ToDateTime("19/03/2002")));
            Alunos.Add(new Aluno(8, "Leandro", 345678, Convert.ToDateTime("13/03/2018")));
            Alunos.Add(new Aluno(9, "Rogerio", 009988, Convert.ToDateTime("03/02/2011")));
            Alunos.Add(new Aluno(10, "Lucas", 364857, Convert.ToDateTime("07/01/2017")));


            return View(Alunos);
        }
    }
}