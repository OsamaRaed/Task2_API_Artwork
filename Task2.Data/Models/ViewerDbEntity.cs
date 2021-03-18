using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class ViewerDbEntity : BaseEntity 
    {
        [Required]

        public string Name { get; set; }
        [Required]

        public string Email{ get; set; }
        public DateTime RegistryDate { get; set; }
        public SubscriptionDbEntity Subscription { get; set; }
        public List<ViewerInterestDbEntity> ViewerIntrests { get; set; }
        public List<ArtworkViewDbEntity> ArtworkViews { get; set; }
     }
}