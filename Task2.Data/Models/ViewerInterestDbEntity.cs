using System;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class ViewerInterestDbEntity : BaseEntity
    {
        [Required]
        public int ViewerId { get; set; }
        public ViewerDbEntity Viewer { get; set; }
        [Required]
        public int InterestId { get; set; }
        public InterestDbEntity Interest { get; set; }

    }
}