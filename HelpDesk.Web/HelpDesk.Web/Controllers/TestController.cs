using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDesk.Web.Models;

namespace HelpDesk.Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            Pagina pagina = new Pagina
            {
              
            };

            Session["Model"] = pagina;

            return View(pagina);
        }

        [HttpPost]
        public void Salvar(Pagina pagina,Cliente cliente)
        {
           // Cliente cliente = new Cliente() { Endereco = Endero, Nome = nome };

            //pagina.Clientes.Add(cliente);
        }
    }
}
