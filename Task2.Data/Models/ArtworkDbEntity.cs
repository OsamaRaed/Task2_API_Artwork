using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class ArtworkDbEntity : BaseEntity
    {
        [Required]

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ShowDate { get; set; }
        public int CategoryId { get; set; }
        public CategoryDbEntity Category { get; set; }
        public List<ViewerDbEntity> Viewers { get; set; }

    }
}
