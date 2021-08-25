using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoClase.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Empleados()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logueo (String Nombre, String DUI)
        {
            if(Nombre.Equals("Vkaiido") && DUI.Equals("7356"))
            {
                return Redirect("/Empleados/SecundarioMenu");
            }
            _=Nombre;
            _ = DUI;
            return Redirect("/Empleados/Error");
        }


        public ActionResult SecundarioMenu()
        {
            return View();
        }

        public ActionResult Error () {

            return View();
        }

        [HttpPost]
        public ActionResult Procesador(String Nombre, String ValorHora, String Antiguedad, String HorasTrabajadas)

        {
            int At= Convert.ToInt32(Antiguedad);
            int Vh = Convert.ToInt32(ValorHora);
            int VHTrab = Convert.ToInt32(HorasTrabajadas);

            ViewBag.nombre = Nombre;
            ViewBag.antiguedad = At;
            ViewBag.vh = Vh;
            ViewBag.TC = (Vh*VHTrab+At*30);
            ViewBag.TDes = (((Vh * VHTrab + At * 30) * 0.13) * 0.13);
            ViewBag.TCDes = ((Vh * VHTrab + At * 30) - ((Vh * VHTrab + At * 30) * 0.13)) - (((Vh * VHTrab + At * 30) * 0.13) * 0.13); 
                                

            _ =Nombre;
            return View(); 
        }
    }
}