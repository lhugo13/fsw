using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SyC.CGRyF.AccesoDatos;

using SyC.CGRyF.Utilerias;

namespace SyC.CGRyF.Administrativo.Areas.Condonaciones.Controllers
{
    public class ContribuyentesController : Controller
    {
        private CNA_SIRFIC_Entities db = new CNA_SIRFIC_Entities();
        Negocio.Catalogos.ContribuyenteBL ctx = new Negocio.Catalogos.ContribuyenteBL();
        // GET: Condonaciones/Contribuyentes
        public async Task<ActionResult> Index(int? pagina)
        {
            int paginaNum = 0;
            paginaNum = pagina ?? 1;
            int totalContribuyentes = await ctx.Contar();
            int contribuyentesPorPagina = 100;
            int contribuyenteInicio = paginaNum * contribuyentesPorPagina;
            int contribuyenteFinal = contribuyenteInicio - contribuyentesPorPagina;

            var contribuyentes = await ctx.GetAll().OrderBy(e => e.id).Skip(contribuyenteFinal).Take(contribuyentesPorPagina).ToListAsync();
            Paginador<tblPuucContribuyente> paginador = new Paginador<tblPuucContribuyente>(contribuyentes.AsQueryable(), paginaNum, contribuyentesPorPagina, totalContribuyentes);
            
            return View(paginador);

            //var tblPuucContribuyentes = db.tblPuucContribuyentes.Include(t => t.tblPuucContadorPublico).Include(t => t.tblPuucRepresentanteLegal).Include(t => t.tblSubRama).Take(5);
            //return View(tblPuucContribuyentes.ToList());
        }

        // GET: Condonaciones/Contribuyentes/Details/5
        public ActionResult Details(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = db.tblPuucContribuyentes.Find(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            return View(tblPuucContribuyente);
        }

        // GET: Condonaciones/Contribuyentes/Create
        public ActionResult Create()
        {
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre");
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre");
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre");
            return View();
        }

        // POST: Condonaciones/Contribuyentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idContadorPublico,cuenta,estatus,granContribuyenteOrParaestatal,nombreComercial,tipoPersona,nombre,apellidoPaterno,apellidoMaterno,rfc,curp,idRepresentanteLegal,idSubSector,fechaRegistro,fechaModificacion,isInscritoREPDA,tieneFiel,actividadPreponderante,idSubRama,esCPR,identificador,preguntaSecreta,esRepresentante,grupoEmpresarial,countEnTramite,countSinTitulo,privilegioEnvio,nombreCompleto,aplicaFortamun,isCFE,alias,idSubTipoPersona,beneficiarioFiscal,observaciones,idClase,idWallet,isMunicipal,validadoSAT,idTipoSociedad")] tblPuucContribuyente tblPuucContribuyente)
        {
            if (ModelState.IsValid)
            {
                db.tblPuucContribuyentes.Add(tblPuucContribuyente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // GET: Condonaciones/Contribuyentes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = db.tblPuucContribuyentes.Find(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // POST: Condonaciones/Contribuyentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idContadorPublico,cuenta,estatus,granContribuyenteOrParaestatal,nombreComercial,tipoPersona,nombre,apellidoPaterno,apellidoMaterno,rfc,curp,idRepresentanteLegal,idSubSector,fechaRegistro,fechaModificacion,isInscritoREPDA,tieneFiel,actividadPreponderante,idSubRama,esCPR,identificador,preguntaSecreta,esRepresentante,grupoEmpresarial,countEnTramite,countSinTitulo,privilegioEnvio,nombreCompleto,aplicaFortamun,isCFE,alias,idSubTipoPersona,beneficiarioFiscal,observaciones,idClase,idWallet,isMunicipal,validadoSAT,idTipoSociedad")] tblPuucContribuyente tblPuucContribuyente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPuucContribuyente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // GET: Condonaciones/Contribuyentes/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = db.tblPuucContribuyentes.Find(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            return View(tblPuucContribuyente);
        }

        // POST: Condonaciones/Contribuyentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tblPuucContribuyente tblPuucContribuyente = db.tblPuucContribuyentes.Find(id);
            db.tblPuucContribuyentes.Remove(tblPuucContribuyente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
