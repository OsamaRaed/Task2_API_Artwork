using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;
using Task2_API.Data.Models;
// NOT Ready
namespace Task2_API.Service.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _DB;
        public CategoryService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<CategoryVM> Index()
        {
            return _DB.Categories.Select(x => new CategoryVM(x)).ToList();

        }

        public CategoryVM Details(int id)
        {
            return new CategoryVM(_DB.Categories.Find(id));
        }

        public void Create(CreateCategoryDTO dTO)
        {
            var Category = new CategoryDbEntity()
            {
                Name = dTO.Name

            };
            //foreach (int artwork in dto.ViewerIntrests)
            //{
            //    var artworkView = new ArtworkViewDbEntity()
            //    {
            //        ArtworkId = artwork,
            //        ViewerId = Createviewer.Id
            //    };
            //    _DB.ArtworkViews.Add(artworkView);
            //    _DB.SaveChanges();
            //}
            _DB.Categories.Add(Category);
            _DB.SaveChanges();

        }

        public void Update(UpdateCategoryDTO dTO)
        {
            //var Category = _DB.Categories.Find(dTO.Id);
            //Category.Name = dTO.Name;
            //_DB.Categories.Update(Category);
            //_DB.SaveChanges();
        }
        public void Delete(int id)
        {
            var Category = _DB.Categories.Find(id);
            Category.IsDelete = true;
            _DB.SaveChanges();
        }
    }
}
