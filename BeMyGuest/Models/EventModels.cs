using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace BeMyGuest.Models
{
    public class EventModels:DbContext
    {
        public EventModels()
            : base("aspnet-BeMyGuest-20150425021944")
        {
        }

        public DbSet<Event> Events { get; set; }
    }
    public class Event
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public int id_user_guest { get; set; }
        public int id_user_owner { get; set; }
        public string status { get; set; }
        public string data_coming { get; set; }
        public string data_departure { get; set; }
        public string description { get; set; }
        public string comment_guest { get; set; }
        public string comment_owner { get; set; }
    }
}