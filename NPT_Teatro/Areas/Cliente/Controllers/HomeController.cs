using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NPT_Teatro.AccesoDatos.Data.Repository;
using NPT_Teatro.Models;
using NPT_Teatro.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NPT_Teatro.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                ListaFunciones = _contenedorTrabajo.Funcion.GetAll()
            };
            return View(homeVm);
        }

        public IActionResult Details(int id)
        {
            var funcionDesdeDb = _contenedorTrabajo.Funcion.GetFirstOrDefault(a => a.Id ==id);
            return View(funcionDesdeDb);
        }

    }
}
