using System;

namespace Task2C._1.Models
{
    public class ArtworkView
    {
        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; }
        public int ViewerId { get; set; }
        public Viewer Viewer { get; set; }
        public float Rating { get; set; }
        public string FeedBack { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}