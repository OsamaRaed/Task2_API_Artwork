using System.Collections.Generic;
using System;
namespace Task2_API.Data.Models
{
    public class InterestDbEntity : BaseEntity
    {
        public int CategoryId { get; set; }
        public CategoryDbEntity Category { get; set; }
        public List<ViewerInterestDbEntity> ViewerInterests { get; set; }

    }
}