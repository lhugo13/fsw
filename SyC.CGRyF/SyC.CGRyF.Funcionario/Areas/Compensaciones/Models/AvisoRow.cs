using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SyC.CGRyF.Funcionario.Areas.Compensaciones.Models
{
    public class AvisoRow
    {
        public long Id { get; set; }
        public string Rfc { get; set; }
        public string NumeroControl { get; set; }
        public string NumeroExpediente { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string EstatusResolucion { get; set; }
    }
}