using MvcS6L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//L'azione "Index" è un metodo nel controller che viene chiamato quando si visita "/Dipendenti"
//Nel controller, recupero i dati dal database, li metto in un modello che poi passo alla view.

namespace MvcS6L1.Controllers
{   
    //Qui domani recupero i dipendenti dal database
    public class DipendentiController : Controller
    {
        // GET: Dipendenti
        public ActionResult Index()
        {
            return View();
        }

        //azione "Create" è un metodo nel controller che viene chiamato quando si visita "/Dipendenti/Create"
        public ActionResult Create()
        {
            return View();
        }

        //Il metodo "Create" è chiamato quando si invia un modulo con il metodo POST
        [HttpPost]
        public ActionResult Create(Dipendente dipendente)
        {
            //salvo il dipendente nel database


            return RedirectToAction("Index");
        }
    }
}