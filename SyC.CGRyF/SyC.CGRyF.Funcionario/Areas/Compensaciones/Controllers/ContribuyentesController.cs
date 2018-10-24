using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SyC.CGRyF.AccesoDatos;

namespace SyC.CGRyF.Administrativo.Areas.Compensaciones.Controllers
{
    public class ContribuyentesController : Controller
    {
        private CNA_SIRFIC_Entities db = new CNA_SIRFIC_Entities();
        Negocio.Catalogos.ContribuyenteBL ctx = new Negocio.Catalogos.ContribuyenteBL();

        // GET: Compensaciones/Contribuyentes
        public async Task<ActionResult> Index(int? page)
        {
            int paginaNum = 0;
            paginaNum = page ?? 1;
            int totalContribuyentes = await ctx.Contar();
            int contribuyentesPorPagina = 100;
            int contribuyenteInicio = paginaNum * contribuyentesPorPagina;
            int contribuyenteFinal = contribuyenteInicio - contribuyentesPorPagina;

            var contribuyentes = await ctx.GetAll().OrderBy(e => e.id).Skip(contribuyenteFinal).Take(contribuyentesPorPagina).ToListAsync();
            var usersAsIPagedList = new X.PagedList.StaticPagedList<tblPuucContribuyente>(contribuyentes, paginaNum, contribuyentesPorPagina, totalContribuyentes);

            ViewBag.OnePageOfUsers = usersAsIPagedList;


            return View();
        }

        // GET: Compensaciones/Contribuyentes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = await db.tblPuucContribuyentes.FindAsync(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            return View(tblPuucContribuyente);
        }

        // GET: Compensaciones/Contribuyentes/Create
        public ActionResult Create()
        {
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre");
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre");
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre");
            return View();
        }

        // POST: Compensaciones/Contribuyentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,idContadorPublico,cuenta,estatus,granContribuyenteOrParaestatal,nombreComercial,tipoPersona,nombre,apellidoPaterno,apellidoMaterno,rfc,curp,idRepresentanteLegal,idSubSector,fechaRegistro,fechaModificacion,isInscritoREPDA,tieneFiel,actividadPreponderante,idSubRama,esCPR,identificador,preguntaSecreta,esRepresentante,grupoEmpresarial,countEnTramite,countSinTitulo,privilegioEnvio,nombreCompleto,aplicaFortamun,isCFE,alias,idSubTipoPersona,beneficiarioFiscal,observaciones,idClase,idWallet,isMunicipal,validadoSAT,idTipoSociedad")] tblPuucContribuyente tblPuucContribuyente)
        {
            if (ModelState.IsValid)
            {
                db.tblPuucContribuyentes.Add(tblPuucContribuyente);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // GET: Compensaciones/Contribuyentes/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = await db.tblPuucContribuyentes.FindAsync(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // POST: Compensaciones/Contribuyentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,idContadorPublico,cuenta,estatus,granContribuyenteOrParaestatal,nombreComercial,tipoPersona,nombre,apellidoPaterno,apellidoMaterno,rfc,curp,idRepresentanteLegal,idSubSector,fechaRegistro,fechaModificacion,isInscritoREPDA,tieneFiel,actividadPreponderante,idSubRama,esCPR,identificador,preguntaSecreta,esRepresentante,grupoEmpresarial,countEnTramite,countSinTitulo,privilegioEnvio,nombreCompleto,aplicaFortamun,isCFE,alias,idSubTipoPersona,beneficiarioFiscal,observaciones,idClase,idWallet,isMunicipal,validadoSAT,idTipoSociedad")] tblPuucContribuyente tblPuucContribuyente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPuucContribuyente).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre", tblPuucContribuyente.idContadorPublico);
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre", tblPuucContribuyente.idRepresentanteLegal);
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre", tblPuucContribuyente.idSubRama);
            return View(tblPuucContribuyente);
        }

        // GET: Compensaciones/Contribuyentes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPuucContribuyente tblPuucContribuyente = await db.tblPuucContribuyentes.FindAsync(id);
            if (tblPuucContribuyente == null)
            {
                return HttpNotFound();
            }
            return View(tblPuucContribuyente);
        }

        // POST: Compensaciones/Contribuyentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            tblPuucContribuyente tblPuucContribuyente = await db.tblPuucContribuyentes.FindAsync(id);
            db.tblPuucContribuyentes.Remove(tblPuucContribuyente);
            await db.SaveChangesAsync();
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
