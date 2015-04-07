using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class Dinner
    {
        [Key]
        public int DinnerId { get; set; }

        public string Title { get; set; }

        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        public string HostedBy { get; set; }

        public string ContactPhone { get; set; }

        public string Adress { get; set; }

        public string Country { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }



    }
  
    public class DinnerDbContext : DbContext
    {
        public DbSet<Dinner> Dinners { get; set; }
    }
}