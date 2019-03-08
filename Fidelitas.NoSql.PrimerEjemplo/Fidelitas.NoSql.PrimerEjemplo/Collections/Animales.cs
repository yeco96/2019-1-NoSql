using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    [MetadataType(typeof(AnimalesMetadata))]
    public class Animales
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))] [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha { get; set; }
        public string Tipo { get; set; }
        public string Dueno { get; set; }
        public int Peso { get; set; }
        public IList<Tratamiento> tratamiento { get; set; }
}
    public class AnimalesMetadata
    {
        [DisplayName("Identificador")]
        public object _id { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public object Nombre { get; set; }

        [DisplayName("Fecha de ingreso")]
        public object fecha { get; set; }

        [DisplayName("Tipo de mascota")]
        public object Tipo { get; set; }

        [Required]
        [DisplayName("Nombre del dueño")]
        public object Dueno { get; set; }

        [Range(1,100)]
        [DisplayName("Peso en libras")]
        public object Peso { get; set; }

        public IList<Tratamiento> tratamiento { get; set; }
    }

    public class Tratamiento
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal precio { get; set; }
    }
}