using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prichici_Sanziana_Lab8.Models;

namespace Prichici_Sanziana_Lab8.Data
{
    public class Prichici_Sanziana_Lab8Context : DbContext
    {
        public Prichici_Sanziana_Lab8Context (DbContextOptions<Prichici_Sanziana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Prichici_Sanziana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Prichici_Sanziana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Prichici_Sanziana_Lab8.Models.Category> Category { get; set; }
    }
}
