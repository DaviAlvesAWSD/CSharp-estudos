using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Davi",
                Tipo = "Administrador"            
            };

            

            return View(pessoa);
        }

        public ActionResult Contacts()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa person)
        {
            /*
            var objPerson = new Pessoa
            {
                PessoaId = person.PessoaId,
                Nome = person.Nome,
                Tipo = person.Tipo
            };
            
             */
            return View(person);
        }
    }
}