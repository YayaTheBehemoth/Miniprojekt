using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace miniproj3.Shared
{
    [BsonIgnoreExtraElements]
    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement]
        public string Name { get; set; }

        [BsonElement]
        public string Email { get; set; }

        [BsonElement]
        public string Adresse { get; set; }

        [BsonElement]
        public string Tlf { get; set; }

        [BsonElement]
        public string By { get; set; }

        [BsonElement]
        public string PostNr { get; set; }

        [BsonElement]
        public string AntalPersoner { get; set; }

        [BsonElement]
        public string Ankomst { get; set; }

        [BsonElement]
        public string Afrejse { get; set; }

        [BsonElement]
        public string Note { get; set; }

        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ShelterId { get; set; }
    }
}
