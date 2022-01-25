﻿using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment _hostingEnviroment;

        public HomeController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnviroment)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnviroment = hostingEnviroment;
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


        [HttpGet]
        public IActionResult Reservar(int? id)
        {
            FuncionVM funvm = new FuncionVM()
            {
                Funcion = new Models.Funcion(),
                ListaObras = _contenedorTrabajo.Obra.GetListaObras()
            };

            if (id != null)
            {
                funvm.Funcion = _contenedorTrabajo.Funcion.Get(id.GetValueOrDefault());
            }

            return View(funvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Reservar(FuncionVM funVM)
        {
            /* if(ModelState.IsValid)
             {*/
            string rutaPrincipal = _hostingEnviroment.WebRootPath;
            var archivos = HttpContext.Request.Form.Files;
            //Obtener archivo por su ID
            var funcionDesdeDb = _contenedorTrabajo.Funcion.Get(funVM.Funcion.Id);

         

            _contenedorTrabajo.Funcion.Update(funVM.Funcion);
            _contenedorTrabajo.Save();

            return RedirectToAction(nameof(Index));
            //}

            /*funVM.ListaObras = _contenedorTrabajo.Obra.GetListaObras();
            return View(funVM);*/
        }
    }
}
