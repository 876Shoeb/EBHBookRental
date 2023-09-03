using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Data
{
    public class BookRentalDbContext : DbContext
    {
        public BookRentalDbContext(DbContextOptions<BookRentalDbContext> options) : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}
