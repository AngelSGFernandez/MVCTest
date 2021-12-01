using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class HomeController: Controller
    {
        private IAmigoAlmacen amigoAlmacen;
        public HomeController(IAmigoAlmacen AmigoAlmacen)
        {
            amigoAlmacen = AmigoAlmacen;
        }

        //public string Index()
        //{
        //    return amigoAlmacen.dameDatosAmigo(1).Email;
        //}

        public ViewResult Index()
        {
            Amigo modelo = amigoAlmacen.dameDatosAmigo(1);
            return View("~/MisVistas/Index2.cshtml");
        }

        public ViewResult Details()
        {
            Amigo modelo = amigoAlmacen.dameDatosAmigo(2);
            return View(modelo);
        }
    }
}
