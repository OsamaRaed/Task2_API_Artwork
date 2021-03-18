using System;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class ArtworkViewDbEntity : BaseEntity
    {
        [Required]

        public int ArtworkId { get; set; }
        public ArtworkDbEntity Artwork { get; set; }
        [Required]

        public int ViewerId { get; set; }
        public ViewerDbEntity Viewer { get; set; }
        public float Rating { get; set; }
        public string FeedBack { get; set; }

    }
}