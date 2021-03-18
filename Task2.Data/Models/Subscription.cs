using System;

namespace Task2C._1.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int ViewerId { get; set; }
        public Viewer Viewer { get; set; }
        public int Price { get; set; }
        public DateTime SubscriptionDate{ get; set; }
        public string SubscriptionTerm { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}