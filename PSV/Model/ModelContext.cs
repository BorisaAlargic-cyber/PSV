using PSV.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("Server=DESKTOP-CRHOBOO;Database=PSV;Trusted_Connection=True;") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Apointment> Apointments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Drugs> Drugs { get; set; }
        public DbSet<Recepie> Recepie { get; set; }

    }
}
