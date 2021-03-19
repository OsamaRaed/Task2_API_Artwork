using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;

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
            return null;
        }

        public SubscriptionVM Details(int id)
        {
            return null;
        }

        public void Create(CreateSubscriptionDTO dTO)
        {

        }

        public void Update(UpdateSubscriptionDTO dTO)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
