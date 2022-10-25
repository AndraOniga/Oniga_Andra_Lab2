using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oniga_Andra_Lab2.Models;

namespace Oniga_Andra_Lab2.Data
{
    public class Oniga_Andra_Lab2Context : DbContext
    {
        public Oniga_Andra_Lab2Context (DbContextOptions<Oniga_Andra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Oniga_Andra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Oniga_Andra_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Oniga_Andra_Lab2.Models.Author> Author { get; set; }
    }
}
