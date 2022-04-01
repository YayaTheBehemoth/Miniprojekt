using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniproj3.Shared;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using MongoDB.Driver;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace miniproj3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterSebController : Controller
    {
        private readonly ILogger<ShelterSebController> logger;

        public ShelterSebController(ILogger<ShelterSebController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<List<ShelterTest>> Get()
        {
            /*
            using (StreamReader r = new StreamReader("SampleDataJson.json"))
            {
                string json = r.ReadToEnd();
                ShelterTest[] jsonItems = JsonConvert.DeserializeObject<ShelterTest[]>(json);
                return jsonItems;
            }
            */
        var client = new MongoClient("mongodb+srv://admin:gQVFvLfgGzueegjf@cluster-shelter.k8pe8.mongodb.net/Shelter-miniproj");

        var database = client.GetDatabase("Shelter-miniproj");

        var collection = database.GetCollection<BsonDocument>("testcoll");

        var list = await collection.Find(_ => true).ToListAsync();

        List<ShelterTest> shelters = new List<ShelterTest>();

        foreach (var item in list)
            {
                ShelterTest test = new ShelterTest();
                test.Id = item["_id"].ToString();
                test.Type = item["type"].ToString();
                test.ShelterName = item["navn"].ToString();
                shelters.Add(test);
            }
        return shelters;
        }
    }
}
