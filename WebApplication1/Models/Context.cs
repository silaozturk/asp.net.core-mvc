﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-O8UQ1L7\\SıLA; database=BirimDB; integrated security=true;");
        }
        public DbSet<Birim>Birims { get; set; }
        public DbSet<Personel>Personels { get; set; }
        public DbSet<Admin>Admins { get; set; }

    }
}
