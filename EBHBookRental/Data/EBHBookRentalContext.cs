using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookRental.Data;

namespace EBHBookRental.Data
{
    public class EBHBookRentalContext : DbContext
    {
        public EBHBookRentalContext (DbContextOptions<EBHBookRentalContext> options)
            : base(options)
        {
        }

        public DbSet<BookRental.Data.Books> Books { get; set; } = default!;
    }
}
