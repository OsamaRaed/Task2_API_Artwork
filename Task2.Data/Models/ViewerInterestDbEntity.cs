using System;

namespace Task2_API.Data.Models
{
    public class ViewerInterestDbEntity : BaseEntity
    {
        public int ViewerId { get; set; }
        public ViewerDbEntity Viewer { get; set; }
        public int InterestId { get; set; }
        public InterestDbEntity Interest { get; set; }

    }
}