using MvcS6L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcS6L1.Controllers

    //qui domani recupero i pagamenti dal database
{
    public class PagamentiController : Controller
    {
        // GET: Pagamenti
        public ActionResult Index()
        {
            return View();
        }

        //azione "Create" è un metodo nel controller che viene chiamato quando si visita "/Pagamenti/Create"
        public ActionResult Create()
        {
            return View();
        }

        //Il metodo "Create" è chiamato quando si invia un modulo con il metodo POST
        [HttpPost]
        public ActionResult Create(Pagamento pagamento)
        {
            //salvo il pagamento nel database

            return RedirectToAction("Index");
        }
    }
}