using SyC.CGRyF.Funcionario.Areas.Compensaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.Compensaciones.Controllers
{
    public class CoreController : Controller
    {
        // GET: Compensaciones/Core
        public ActionResult Index()
        {
            TramitesPendientes tramites = new TramitesPendientes();
            tramites.Registros = new List<AvisoRow>();
            tramites.Paginado = new List<int>();

            //TEST DATA
            for (int i = 1; i < 11; i++)
            {
                tramites.Registros.Add(new AvisoRow()
                {
                    Id = i,
                    EstatusResolucion = "OK",
                    FechaEnvio = DateTime.Now,
                    NumeroControl = "NC_" + i.ToString(),
                    Rfc = "RFC" + i.ToString(),
                    NumeroExpediente = "NE_" + i.ToString()
                });
            }

            for(int i = 1; i < 5; i++)
            {
                tramites.Paginado.Add(i);
            }

            return View(tramites);
        }

        // GET: Compensaciones/Core/Solicitud
        public ActionResult Solicitud(long id, int op)
        {
            AvisoResolucion avisoResolucion = new AvisoResolucion();
            avisoResolucion.Compensaciones = new List<CompensacionesAplicadas>();

            for(long i = 1; i < 5; i++)
            {
                avisoResolucion.Compensaciones.Add(new CompensacionesAplicadas()
                {
                    Origen_Fecha = DateTime.Now,
                    Origen_Folio = i,
                    Compensa_Fecha = DateTime.Now,
                    Compensa_Folio = i + 1,
                    Id = i,
                    InpcActual = 1.15M,
                    InpcAntiguo = 1.48M,
                    MontoActualizado = 10000M,
                    MontoHistorico = 500M         

                });
            }

            avisoResolucion.Option = op;
            avisoResolucion.IdSolicitud = id;

            return View(avisoResolucion);
        }
    }
}