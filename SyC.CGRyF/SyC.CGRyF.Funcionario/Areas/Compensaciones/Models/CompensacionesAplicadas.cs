using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyC.CGRyF.Funcionario.Areas.Compensaciones.Models
{
    public class CompensacionesAplicadas
    {
        public long Id { get; set; }
        public long Origen_Folio { get; set; }
        public DateTime Origen_Fecha { get; set; }
        public long Compensa_Folio { get; set; }
        public DateTime Compensa_Fecha { get; set; }
        public decimal InpcAntiguo { get; set; }
        public decimal InpcActual { get; set; }
        public decimal MontoHistorico { get; set; }
        public decimal MontoActualizado { get; set; }
    }
}