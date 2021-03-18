using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class CategoryVM
    {
        public CategoryVM() { }
        public CategoryVM(CategoryDbEntity category)
        {
            Name = category.Name;
        }
        public string Name { get; set; }

    }
}
