using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Task2_API.Data.Models
{
    public class InterestDbEntity : BaseEntity
    {
        [Required]
        public int CategoryId { get; set; }
        public CategoryDbEntity Category { get; set; }
        public List<ViewerInterestDbEntity> ViewerInterests { get; set; }

    }
}