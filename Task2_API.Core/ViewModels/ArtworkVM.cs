using System;
using Task2_API.Data.Models;
 
namespace Task2_API.Core.ViewModel
{
    public class ArtworkVM
    {
        public ArtworkVM() { }
        public ArtworkVM(ArtworkDbEntity artwork)
        {
            Category = new CategoryVM(artwork.Category);
            Name = artwork.Name;
            Description = artwork.Description;
            ShowDate = artwork.ShowDate;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ShowDate { get; set; }
        //public int CategoryId { get; set; }
        public CategoryVM Category { get; set; }

    }
}
