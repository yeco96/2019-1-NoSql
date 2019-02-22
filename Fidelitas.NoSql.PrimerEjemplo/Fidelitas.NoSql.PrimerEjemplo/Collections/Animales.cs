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
        ObjectId _id;
        string Nombre;
        DateTime fecha;
        string Tipo;
        string Dueno;
        IList <Tratamiento> tratamiento;
    }
    public class Tratamiento
    {
        string Tipo;
        DateTime Fecha;
        decimal precio;
    }
}