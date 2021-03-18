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
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistryDate { get; set; }
        public SubscriptionVM Subscription { get; set; }
    }
}
