using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookRental.Data;
using EBHBookRental.Data;

namespace EBHBookRental.Pages.RentalBooks
{
    public class IndexModel : PageModel
    {
        private readonly EBHBookRental.Data.EBHBookRentalContext _context;

        public IndexModel(EBHBookRental.Data.EBHBookRentalContext context)
        {
            _context = context;
        }

        public IList<Books> Books { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Books = await _context.Books.ToListAsync();
            }
        }
    }
}
