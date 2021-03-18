using System;
using System.Collections.Generic;

namespace Task2C._1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Artwork> Artworks { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
