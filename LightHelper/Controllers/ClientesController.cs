using LightHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LightHelper.Controllers
{
    public class ClientesController : Controller
    {
        private static IList<Cliente> clientes = new List<Cliente>()
        {
            new Cliente(){
                ClienteID=1,
                Nome = "Guilherme",
                CPF = 123456789,
                Telefone = 99914545,
                Email = "mrguilher621@gmail.com"
            },

              new Cliente(){
                ClienteID = 2,
                Nome = "Lucas",
                CPF = 987456123,
                Telefone = 99914669,
                Email = "lucas@gmail.com"
            }

        };
        // GET: Clientes
        public ActionResult Index()
        {
            return View(clientes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            clientes.Add(cliente);
            cliente.ClienteID = clientes.Select(c => c.ClienteID).Max() + 1;
            return RedirectToAction("Index");
        }
    }
}