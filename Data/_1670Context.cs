using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1670.Models;

namespace _1670.Data
{
    public class _1670Context : DbContext
    {
        public _1670Context (DbContextOptions<_1670Context> options)
            : base(options)
        {
        }

        public DbSet<_1670.Models.Category> Category { get; set; } = default!;

        public DbSet<_1670.Models.Book> Book { get; set; } = default!;
    }
}
