using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;

namespace Task2_API.Service.Services.Category
{
    public interface ICategoryService
    {
        List<CategoryVM> Index();
        CategoryVM Details(int id);
        void Create(CreateCategoryDTO dTO);
        void Update(UpdateCategoryDTO dTO);
        void Delete(int id);
    }
}
