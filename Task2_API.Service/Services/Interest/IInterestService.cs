using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;

namespace Task2_API.Service.Services.Interest
{
    public interface IInterestService
    {
        List<InterestVM> Index();
        InterestVM Details(int id);
        void Create(CreateInterestDTO dTO);
        void Update(UpdateInterestDTO dTO);
        void Delete(int id);
    }
}
