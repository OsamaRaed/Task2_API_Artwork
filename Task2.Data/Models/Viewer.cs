using System;
using System.Collections.Generic;

namespace Task2C._1.Models
{
    public class Viewer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateTime RegistryDate { get; set; }
        public Subscription Subscription { get; set; }
        public List<ViewerInterest> ViewerIntrests { get; set; }
        public List<ArtworkView> ArtworkViews { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}