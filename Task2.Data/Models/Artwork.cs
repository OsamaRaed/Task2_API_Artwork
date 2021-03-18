using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2C._1.CreateDTO;

namespace Task2C._1.Models
{
    public class Artwork
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ShowDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Viewer> Viewers { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
