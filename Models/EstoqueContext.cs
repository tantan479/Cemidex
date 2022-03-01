using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cemidex.Models
{
    internal class CemidexContext : DbContext
    {
        public DbSet<Cova> Covas { get; set; }

        public DbSet<Falecido> Falecidos { get; set; }

        public DbSet<Requerente> Requerentes { get; set;}

        public DbSet<Sepultamento> Sepultamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=cemidex.db");
        }

    }
}
