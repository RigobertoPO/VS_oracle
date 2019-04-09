using MVCOracle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOracle.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var conexion = new OracleEntities())
            {
                var query = (from p in conexion.PRODUCTOS
                             select p).ToList();
                return View(query);
            }
        }
    }
}