using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelter_miniproj.Shared.Models
{
    public class booking
{
    [BsonId]
    [BsonGuidRepresentation((GuidRepresentation)BsonType.ObjectId)]
    public string id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public int Tlf { get; set; }
        public string Adresse { get; set; }
        public int Postnummer { get; set; }
        public double Shelter { get; set; }
        public int Antal_Personer { get; set; }
        public DateTime Dato_for_Ankomst { get; set; }
        public DateTime Dato_for_Afrejse { get; set; }
        public string Note { get; set; }
        public object Id { get; set; }
    }
}
