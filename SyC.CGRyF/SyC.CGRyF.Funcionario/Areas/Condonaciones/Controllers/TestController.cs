using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.Condonaciones.Controllers
{
    public class TestController : Controller
    {
        // GET: Condonaciones/Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: Condonaciones/Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Condonaciones/Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Condonaciones/Test/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Condonaciones/Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Condonaciones/Test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Condonaciones/Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Condonaciones/Test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
