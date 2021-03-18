using System.Collections.Generic;
using System;
namespace Task2C._1.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ViewerInterest> ViewerInterests { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}