using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospitalDirectory.Models
{
    public class HospitalDirectoryContext : DbContext
    {
        public HospitalDirectoryContext() : base("hospitalDatabase")
        {
        }

        //Entities
        public DbSet<Hospital> Hospitals { get; set; }
    }
}