using Fidelitas.NoSql.PrimerEjemplo.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fidelitas.NoSql.PrimerEjemplo.Controllers
{
    public class AnimalController : Controller
    {
        public IMongoDatabase database;
        public AnimalController()
        {
            var connectionString = Properties.Settings.Default.mongoConnection;
            var client = new MongoClient (connectionString);
            database = client.GetDatabase(Properties.Settings.Default.databaseName);
       }


        // GET: Animal
        public JsonResult Index()
        {
            var animales = database.GetCollection<Animales>("animales");
            var res = Json (new { id = 1, hello = "world" } );
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        // GET: Animal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Animal/Create
        public ActionResult Insertar()
        {
            return View();
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Insertar(Animales laMascota)
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

        // GET: Animal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animal/Edit/5
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

        // GET: Animal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animal/Delete/5
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
