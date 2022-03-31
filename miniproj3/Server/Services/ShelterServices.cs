using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;
using miniproj3.Shared;
using MongoDB.Bson;
using System;
namespace miniproj3.Server.Services
{/*
    public class ShelterServices1
    {
        private IMongoCollection<BsonDocument> _shelters;
        public ShelterServices1(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoCloud"));
            var database = client.GetDatabase("Shelter-miniproj");
            _shelters = database.GetCollection<BsonDocument>("testcoll");

        }
        public List<ShelterTest> GetShelterTests()
        {
            var list = _shelters.Find(_ => true).ToList();
            List<ShelterTest> list1 = new List<ShelterTest>();
            foreach (var shelter in list)
            {
                ShelterTest test = new ShelterTest();
                test.Id = shelter["_id"].ToString();
                test.Type = shelter["type"].ToString();
                list1.Add(test);
            }
            return list1;
        }*/
    }
    public class ShelterServices
    {
        private IMongoCollection<Booking> _shelters;
        private IMongoCollection<BsonDocument> _shelters1;
    private IMongoCollection<BsonDocument> _shelters3;

    public ShelterServices(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoCloud"));
            var database = client.GetDatabase("Shelter-miniproj");
            _shelters = database.GetCollection<Booking>("bookingtest2");
           _shelters1 = database.GetCollection<BsonDocument>("bookingtest2");
        _shelters3 = database.GetCollection<BsonDocument>("testcoll");



    }
    public List<ShelterTest> GetShelterTests()
    {
        var list = _shelters3.Find(_ => true).ToList();
        List<ShelterTest> list1 = new List<ShelterTest>();
        foreach (var shelter in list)
        {
            ShelterTest test = new ShelterTest();
            test.Id = shelter["_id"].ToString();
            test.Type = shelter["type"].ToString();
            list1.Add(test);
        }
        return list1;
    }
            public List<Booking> GetShelters()
        {
            var list =  _shelters1.Find(_ => true).ToList();
            List<Booking> list1 = new List<Booking>();
            foreach (var shelter in list)
            {
                Booking test = new Booking();
                test.Id = shelter["_id"].ToString();
                test.Name = shelter["Name"].ToString();
                test.Email = shelter["Email"].ToString();
                test.Tlf = shelter["Tlf"].ToString();
                test.Adresse = shelter["Adresse"].ToString();
                test.By = shelter["By"].ToString();
                test.PostNr = shelter["PostNr"].ToString();
                test.AntalPersoner = shelter["AntalPersoner"].ToString();
                test.Ankomst = shelter["Ankomst"].ToString();
                test.Afrejse = shelter["Afrejse"].ToString();
                test.Note= shelter["Note"].ToString();
                
                list1.Add(test);
            }
            return list1;
        }
       // public List<ShelterTest> GetShelters() => _shelters.Find(shelter => true).ToList();

        public Booking GetShelter(string id) => _shelters.Find(Booking => Booking.Id == id).FirstOrDefault();
        public Booking postShelter (Booking booking)
        {
            _shelters.InsertOne(booking);
            return booking;

        }
        public Booking putShelter(string id, Booking newBooking)
        {
            _shelters.ReplaceOne(newBooking => newBooking.Id == id, newBooking);
                return newBooking;
        }
        public Booking deleteShelter (string id)
        {
            var newBooking = _shelters.Find(shelter => shelter.Id == id).FirstOrDefault();
            _shelters.DeleteOne(shelter => shelter.Id == id);
            return newBooking;
        }
    }

