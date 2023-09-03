using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Data
{
    public class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PublisherId { get; set; }
        
        public string? PublishedDate { get; set; }
        [DataType(DataType.Date)]
        public int GenreId { get; set; }
        public string? CurrentCondition { get; set; }
        public int CallNumber { get; set; }
        public int RentalRecordsId { get; set; }

    }
}
