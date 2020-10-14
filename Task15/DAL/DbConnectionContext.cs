using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    class DbConnectionContext : DbContext
    { 

        protected DbSet<User> Users { get; set; }
        protected DbSet<Prize> Prizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Task16; Trusted_Connection=True");
        }
    }
}
