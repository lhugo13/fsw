using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyC.CGRyF.Funcionario.Areas.Compensaciones.Models
{
    public class TramitesPendientes
    {
        public int Pagina { get; set; }
        public List<AvisoRow> Registros { get; set; }
        public List<int> Paginado { get; set; }
    }
}