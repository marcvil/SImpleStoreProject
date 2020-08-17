using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.Models
{
    public class Movie
    {
        public long MovieId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Studio Studio { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
