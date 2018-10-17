using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstAppMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string nome, int id) {
            return "Seu nome é  " + nome + " e seu id é " + id;
        }

        public string BemVindo() {
            return "Seja bem vindo ao meu mundo";
        }
    }
}