using System;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class ArtworkViewVM
    {
        public ArtworkViewVM() { }
        public ArtworkViewVM(ArtworkViewDbEntity artworkView)
        {
            Artwork = new ArtworkVM(artworkView.Artwork);
            Viewer = new ViewerVM(artworkView.Viewer);
            Rating = artworkView.Rating;
            FeedBack = artworkView.FeedBack;
        }
        public ArtworkVM Artwork { get; set; }
        public ViewerVM Viewer { get; set; }
        public float Rating { get; set; }
        public string FeedBack { get; set; }

    }
}