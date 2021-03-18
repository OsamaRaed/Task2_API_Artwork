using System;
namespace Task2_API.Core.DTO
{
    public class UpdateSubscriptionDTO
    {
        public int Id { get; set; }

        public int ViewerId { get; set; }
        public int Price { get; set; }
        public DateTime SubscriptionDate{ get; set; }
        public string SubscriptionTerm { get; set; }

    }
}