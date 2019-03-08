using Fidelitas.NoSql.PrimerEjemplo.Collections;
using Fidelitas.NoSql.PrimerEjemplo.Models;
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
        /*
         * {
    "_id" : ObjectId("5c7890162e132d0a74ea1316"),
    "Nombre" : "firulais",
    "fecha" : ISODate("2005-01-01T06:00:00.000Z"),
    "Tipo" : "hamster",
    "Dueno" : "pepito",
    "Peso" : 5,
    "tratamiento" : null
}

            {
    "_id" : ObjectId("5c7893ec2e132d045802429d"),
    "Nombre" : "Chita",
    "fecha" : ISODate("1989-01-01T06:00:00.000Z"),
    "Tipo" : "Chimpancé",
    "Dueno" : "Tarzán",
    "Peso" : 10,
    "tratamiento" : null
}
         * 
         */

        private ContextoMongo elContexto = new ContextoMongo();

        public ActionResult LosTratamientos(string id)
        {
            var animales = elContexto.LosAnimales;
            //var filter = Builders<Animales>.Filter.Eq(x => x._id, id);

            var elAnimalito = animales.Find<Animales>(a => a._id == id).FirstOrDefault();
            return View(elAnimalito.tratamiento);
        }


        // GET: Animal
        public ActionResult Index()
        {
            var animales = elContexto.LosAnimales;
            var losAnimalitos = animales.AsQueryable().ToList();
            return View(losAnimalitos);
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
                var animales = elContexto.LosAnimales;
                laMascota.tratamiento = new List<Tratamiento> ();
                animales.InsertOne(laMascota);

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
