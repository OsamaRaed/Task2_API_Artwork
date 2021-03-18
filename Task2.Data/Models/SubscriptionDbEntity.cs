using System;

namespace Task2_API.Data.Models
{
    public class SubscriptionDbEntity : BaseEntity
    {
        public int ViewerId { get; set; }
        public ViewerDbEntity Viewer { get; set; }
        public int Price { get; set; }
        public DateTime SubscriptionDate{ get; set; }
        public string SubscriptionTerm { get; set; }

    }
}