using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Musca_Andrei_Lab8.Models;

namespace Musca_Andrei_Lab8.Data
{
    public class Musca_Andrei_Lab8Context : DbContext
    {
        public Musca_Andrei_Lab8Context (DbContextOptions<Musca_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Musca_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Musca_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Musca_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
