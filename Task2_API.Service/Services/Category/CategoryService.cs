﻿using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;

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
            return null;
        }

        public CategoryVM Details(int id)
        {
            return null;
        }

        public void Create(CreateCategoryDTO dTO)
        {

        }

        public void Update(UpdateCategoryDTO dTO)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
