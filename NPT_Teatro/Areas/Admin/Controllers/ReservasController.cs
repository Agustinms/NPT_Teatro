using Microsoft.AspNetCore.Mvc;
using NPT_Teatro.AccesoDatos.Data.Repository;

using NPT_Teatro.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPT_Teatro.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;


        public ReservasController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
           

            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            ReservaVM resVM = new ReservaVM()
            {
                Reserva = new Models.Reserva(),
                ListaFunciones = _contenedorTrabajo.Funcion.GetListaFunciones()
            };

            return View(resVM);
        }

        [HttpPost]
        public IActionResult Create(ReservaVM resVM, int cantReservas)
        {


            if (resVM.Reserva.Id == 0)
            {

                _contenedorTrabajo.Reserva.Add(resVM.Reserva);

                var funcionDesdeDb = _contenedorTrabajo.Funcion.Get(resVM.Reserva.FuncionId);
                funcionDesdeDb.Cupo = funcionDesdeDb.Cupo - cantReservas;
                var reservaDesdeDb = _contenedorTrabajo.Reserva.Get(resVM.Reserva.Id);

                resVM.Reserva.Funcion.UrlImagen = funcionDesdeDb.UrlImagen;
                resVM.Reserva.Funcion.ObraId = funcionDesdeDb.ObraId;
                resVM.Reserva.Funcion.Obra = funcionDesdeDb.Obra;
                resVM.Reserva.Funcion.Id = funcionDesdeDb.Id;
                resVM.Reserva.Funcion.Fecha = funcionDesdeDb.Fecha;
                resVM.Reserva.CantEntradas = cantReservas;


                _contenedorTrabajo.Funcion.Update(resVM.Reserva.Funcion);
                _contenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));

            }
            resVM.ListaFunciones = _contenedorTrabajo.Funcion.GetListaFunciones();
            return View(resVM);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var reservaDesdeDb = _contenedorTrabajo.Reserva.Get(id);
            //Obtener la ruta de la imagen en el proyecto
           


            if (reservaDesdeDb == null)
            {
                return Json(new { success = false, message = "Error borrando reserva" });
            }

            _contenedorTrabajo.Reserva.Remove(reservaDesdeDb);
            _contenedorTrabajo.Save();
            return Json(new { success = true, message = "Reserva borrada con éxito" });

        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ReservaVM resVM = new ReservaVM()
            {
                Reserva = new Models.Reserva(),
                ListaFunciones = _contenedorTrabajo.Funcion.GetListaFunciones()
            };

            if (id != null)
            {
                resVM.Reserva = _contenedorTrabajo.Reserva.Get(id.GetValueOrDefault());
            }

            return View(resVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ReservaVM resVM)
        {
          
           
            var reservaDesdeDb = _contenedorTrabajo.Reserva.Get(resVM.Reserva.Id);

                        

            _contenedorTrabajo.Reserva.Update(resVM.Reserva);
            _contenedorTrabajo.Save();

            return RedirectToAction(nameof(Index));
           

        }








        #region LLAMADAS A LA API
        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _contenedorTrabajo.Reserva.GetAll(includeProperties: "Funcion") });
        }


        #endregion
    }
}
