using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fidelitas.NoSql.PrimerEjemplo.Collections
{
    /*
    "_id" : 1,
    "nombre" : "firulais",
    "fecha" : ISODate("2019-01-01T00:00:00.000Z"),
    "tipo" : "perro",
    "dueno" : "pepito",
    "tratamiento" : [
        {
            "tipo" : "operación",
            "fecha" : ISODate("2019-02-01T00:00:00.000Z"),
            "precio" : 500

      */
    public class Animales
    {
        public ObjectId _id { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha { get; set; }
        public string Tipo { get; set; }
        public string Dueno { get; set; }
        public IList<Tratamiento> tratamiento { get; set; }
}
    public class Tratamiento
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal precio { get; set; }
    }
}