using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyC.CGRyF.Funcionario.Areas.Compensaciones.Models
{
    public class AvisoResolucion
    {
        public long IdSolicitud { get; set; }
        public List<CompensacionesAplicadas> Compensaciones { get; set; }
        public int Option { get; set; }
    }
}