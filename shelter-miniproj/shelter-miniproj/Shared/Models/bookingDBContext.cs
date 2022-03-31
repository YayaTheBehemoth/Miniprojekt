using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace shelter_miniproj.Shared.Models
{
    
        public class bookingDBContext
        {
            private readonly IMongoDatabase _mongoDatabase;

            public bookingDBContext()
            {
                var client = new MongoClient("mongodb://localhost:5980");
                _mongoDatabase = client.GetDatabase("bookingDB");
            }

            public IMongoCollection<booking> bookingRecord
            {
                get
                {
                    return _mongoDatabase.GetCollection<booking>("bookingRecord");
                }
            }

            public IMongoCollection<shelter> shelterRecord
            {
                get
                {
                    return _mongoDatabase.GetCollection<shelter>("shelter");
                }
            }
        }
    }

