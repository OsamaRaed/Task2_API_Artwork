using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;
using Task2_API.Data.Models;

namespace Task2_API.Service.Services.Interest
{
    public class InterestService : IInterestService
    {
        private readonly ApplicationDbContext _DB;
        public InterestService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<InterestVM> Index()
        {
            return _DB.Interests.Include(x => x.Category).Include(x => x.ViewerInterests)
                .ThenInclude(x => x.Viewer).Select(x => new InterestVM(x)).ToList();
        }

        public InterestVM Details(int id)
        {
            return new InterestVM(_DB.Interests.Include(x => x.Category).Include(x => x.ViewerInterests)
                .ThenInclude(x => x.Viewer).SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateInterestDTO dto)
        {
            var CreateInterest = new InterestDbEntity()
            {
                CategoryId = dto.CategoryId,
                CreatedAt = DateTime.Now
            };
            _DB.Interests.Add(CreateInterest);
            _DB.SaveChanges();
            foreach (int viewer in dto.viewers)
            {
                var ViewerInterest = new ViewerInterestDbEntity()
                {
                    ViewerId = viewer,
                    InterestId = CreateInterest.Id
                };
                _DB.ViewerInterests.Add(ViewerInterest);
                _DB.SaveChanges();
            }
 
        }

        public void Update(UpdateInterestDTO dTO)
        {

        }
        public void Delete(int id)
        {
            var Interest = _DB.Interests.Find(id);
            Interest.IsDelete = true;
            _DB.Interests.Update(Interest);
            _DB.SaveChanges();
        }
    }
}
