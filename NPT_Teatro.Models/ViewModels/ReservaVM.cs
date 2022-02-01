using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPT_Teatro.Models.ViewModels
{
   public class ReservaVM
    {

        public Reserva Reserva { get; set; }
        public IEnumerable<SelectListItem> ListaFunciones { get; set; }

    }
}
