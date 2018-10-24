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

namespace SyC.CGRyF.Administrativo.Controllers
{
    public class ContribuyentesController : Controller
    {
        private CNA_SIRFIC_Entities db = new CNA_SIRFIC_Entities();

        // GET: Contribuyentes
        public async Task<ActionResult> Index()
        {
            var tblPuucContribuyentes = db.tblPuucContribuyentes.Include(t => t.tblPuucContadorPublico).Include(t => t.tblPuucRepresentanteLegal).Include(t => t.tblSubRama).Take(10);
            return View(await tblPuucContribuyentes.ToListAsync());
        }

        // GET: Contribuyentes/Details/5
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

        // GET: Contribuyentes/Create
        public ActionResult Create()
        {
            ViewBag.idContadorPublico = new SelectList(db.tblPuucContadorPublicoes, "id", "nombre");
            ViewBag.idRepresentanteLegal = new SelectList(db.tblPuucRepresentanteLegals, "id", "nombre");
            ViewBag.idSubRama = new SelectList(db.tblSubRamas, "id", "nombre");
            return View();
        }

        // POST: Contribuyentes/Create
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

        // GET: Contribuyentes/Edit/5
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

        // POST: Contribuyentes/Edit/5
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

        // GET: Contribuyentes/Delete/5
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

        // POST: Contribuyentes/Delete/5
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
