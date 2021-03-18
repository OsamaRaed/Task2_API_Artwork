using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class SubscriptionVM
    {
        public SubscriptionVM() { }
        public SubscriptionVM(SubscriptionDbEntity subscription)
        {
            Viewer = new ViewerVM(subscription.Viewer);
            Price = subscription.Price;
            SubscriptionDate = subscription.SubscriptionDate;
            SubscriptionTerm = subscription.SubscriptionTerm;
        }
        //public int ViewerId { get; set; }
        public ViewerVM Viewer { get; set; }
        public int Price { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public string SubscriptionTerm { get; set; }

    }
}
