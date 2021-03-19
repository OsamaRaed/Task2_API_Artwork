using System;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class SubscriptionDbEntity : BaseEntity
    {
        [Required]
        public int ViewerId { get; set; }
        public ViewerDbEntity Viewer { get; set; }
        [Required]
        public int Price { get; set; }
        public DateTime SubscriptionDate{ get; set; }
        public string SubscriptionTerm { get; set; }

    }
}