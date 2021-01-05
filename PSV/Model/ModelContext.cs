using Microsoft.EntityFrameworkCore;
using PSV.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() { }

        public DbSet<User> Users { get; set; }
        public DbSet<Apointment> Apointments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Termin> Termins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if (optionsBuilder.IsConfigured) {
                return;
            }

            optionsBuilder.UseSqlServer("Server=DESKTOP-CRHOBOO;Database=PSV;Trusted_Connection=True;");
        }
    }
}
