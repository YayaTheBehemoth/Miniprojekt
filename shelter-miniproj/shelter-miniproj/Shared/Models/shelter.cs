using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace shelter_miniproj.Shared.Models
{
    public class shelter
    {
        [BsonId]
        [BsonGuidRepresentation((GuidRepresentation)BsonType.ObjectId)]
        public double _Id { get; set; }
        public string status { get; set; }
        public string note { get; set; }
        public string beskrivels { get; set; }
        public string vejnavn { get; set; }
        public string type { get; set; }
        
    }
}
