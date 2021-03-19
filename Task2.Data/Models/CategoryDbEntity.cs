using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class CategoryDbEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public List<InterestDbEntity> Interests { get; set; }
        public List<ArtworkDbEntity> Artworks { get; set; }

    }
}
