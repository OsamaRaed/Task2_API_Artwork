using System;

namespace Task2_API.Core.DTO
{
    public class CreateArtworkViewDTO
    {
        public int ArtworkId { get; set; }
        public int ViewerId { get; set; }
        public float Rating { get; set; }
        public string FeedBack { get; set; }

    }
}