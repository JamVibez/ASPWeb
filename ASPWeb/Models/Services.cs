using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPWeb.Models
{
    public class Services
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
    }

    public class ServicesDBContext : DbContext
    {
        public DbSet<Services> Services { get; set; }
    }
}