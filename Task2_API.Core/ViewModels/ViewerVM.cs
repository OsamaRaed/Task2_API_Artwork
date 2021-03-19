using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class ViewerVM
    {
        public ViewerVM() { }
        public ViewerVM(ViewerDbEntity viewer)
        {
            Name = viewer.Name;
            Email = viewer.Email;
            RegistryDate = viewer.RegistryDate;
            Subscription = new SubscriptionVM(viewer.Subscription);
            Artworks = viewer.ArtworkViews.Select(x => new ArtworkVM(x.Artwork)).ToList();
            Intrests = viewer.ViewerIntrests.Select(x => new InterestVM(x.Interest)).ToList();
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistryDate { get; set; }
        public SubscriptionVM Subscription { get; set; }
        public List<InterestVM> Intrests { get; set; }
        public List<ArtworkVM> Artworks { get; set; }
    }
}
