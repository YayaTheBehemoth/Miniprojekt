using shelter_miniproj.Shared.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                db.bookingRecord.ReplaceOne(filter: g => g._id == booking._id, replacement: booking);
                
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

    }
}

