using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDandSearch.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseTime { get; set; }
    }
}
