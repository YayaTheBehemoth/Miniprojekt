using shelter_miniproj.Shared.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolrNet.Utils;

namespace shelter_miniproj.Server.DataAccess
{
    public class bookingDataAccessLayer
{
        bookingDBContext db = new bookingDBContext();


        // For at fremkalde alle booking detaljer

        public List<booking> GetAllBookings()
        {
            try
            {
                return db.bookingRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        // For at opdatere en specifik booking
        public void Updatebooking(booking booking)
        {
            try
            {
                db.bookingRecord.ReplaceOne(filter: g => g.id == booking.id, replacement: booking);
            }
            catch
            {
                throw;
            }
            }

        // For at få shelter liste frem

        public List<shelter>GetShelterData()
        {
            try
            {
                return db.shelterRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<booking> GetbookingData(string id)
        {
            try
            {
                return db.bookingRecord.Find(_ => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void Deletebooking(string id)
        {
            try
            {
                FilterDefinition<booking> bookingData = Builders<booking>.Filter.Eq("Id", id);
                db.bookingRecord.DeleteOne(bookingData);
            }
            catch
            {
                throw;
            }

        }
    }
}

