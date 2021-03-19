using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;
using Task2_API.Data.Models;

namespace Task2_API.Service.Services.Subscription
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ApplicationDbContext _DB;
        public SubscriptionService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<SubscriptionVM> Index()
        {
            return _DB.Subscriptions.Include(x => x.Viewer).
                Select(x => new SubscriptionVM() 
                {
                    Price = x.Price,
                    SubscriptionDate = x.SubscriptionDate,
                    SubscriptionTerm = x.SubscriptionTerm,
                    Viewer = new ViewerVM()
                    {
                        Name = x.Viewer.Name,
                        Email = x.Viewer.Email,
                        RegistryDate = x.Viewer.RegistryDate
                    }
                }).ToList();
        }

        public SubscriptionVM Details(int id)
        {
            return new SubscriptionVM(_DB.Subscriptions
                .Include(x => x.Viewer).SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateSubscriptionDTO dTO)
        {
            var subscription = new SubscriptionDbEntity()
            {
                ViewerId = dTO.ViewerId,
                Price = dTO.Price,
                SubscriptionDate = dTO.SubscriptionDate,
                SubscriptionTerm = dTO.SubscriptionTerm,
                IsDelete = false,
                CreatedAt = DateTime.Now
            };
        }

        public void Update(UpdateSubscriptionDTO dTO)
        {

        }
        public void Delete(int id)
        {
            var subscription = _DB.Subscriptions.Find(id);
            subscription.IsDelete = true;
            _DB.Subscriptions.Update(subscription);
        }
    }
}
