using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class InterestVM
    {
        public InterestVM() { }
        public InterestVM(InterestDbEntity interest)
        {
            Category = new CategoryVM(interest.Category);
            Viewers = interest.ViewerInterests.Select(x => new ViewerVM(x.Viewer)).ToList();


        }
        public CategoryVM Category { get; set; }
        public List<ViewerVM> Viewers { get; set; }

    }
}
