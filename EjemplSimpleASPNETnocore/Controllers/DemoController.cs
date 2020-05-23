using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Web.Mvc;
using EjemplSimpleASPNETnocore.Models;

namespace EjemplSimpleASPNETnocore.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            //Ejemplo 1
            ViewBag.edad = 20;//Recibir int
            ViewBag.Nombre = "Pepe";//string
            ViewBag.Casado = false;//bool
            ViewBag.estatura = 1.8;//double (flotante)
            ViewBag.fechaNacimiento = DateTime.Now;//Fechas

            //Ejemplo 2
            Producto prod = new Producto() {
                Id = "pro01",
                Nombre = "Nombre 01",
                Precio = 20.5,
                Cantidad = 40,
                Imagen = "pro01.jpg"
            };
            ViewBag.product = prod;

            //Ejemplo 3
            List<Producto> miLista = new List<Producto>() {
                new Producto() {
                Id = "pro01",
                Nombre = "Nombre 01",
                Precio = 20.5,
                Cantidad = 40,
                Imagen = "pro01.jpg"
            },
                new Producto() {
                Id = "pro02",
                Nombre = "Nombre 02",
                Precio = 20.5,
                Cantidad = 40,
                Imagen = "pro01.jpg"
            },
                new Producto() {
                Id = "pro03",
                Nombre = "Nombre 03",
                Precio = 20.5,
                Cantidad = 40,
                Imagen = "pro01.jpg"
            }
            };
            ViewBag.lista = miLista;
            return View();
        }
    }
}