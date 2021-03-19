using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;

namespace Task2_API.Service.Services.Subscription
{
    public interface ISubscriptionService
    {
        List<SubscriptionVM> Index();
        SubscriptionVM Details(int id);
        void Create(CreateSubscriptionDTO dTO);
        void Update(UpdateSubscriptionDTO dTO);
        void Delete(int id);
    }
}
