using System;

namespace Task2C._1.Models
{
    public class ViewerInterest
    {
        public int ViewerId { get; set; }
        public Viewer Viewer { get; set; }
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}