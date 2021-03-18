using System;
using Task2_API.Data.Models;

namespace Task2_API.Core.ViewModel
{
    public class ViewerInterestVM
    {
        public ViewerInterestVM() { }
        public ViewerInterestVM(ViewerInterestDbEntity viewerInterest)
        {
            Viewer = new ViewerVM(viewerInterest.Viewer);
            Interest = new InterestVM(viewerInterest.Interest);
        }
        //public int ViewerId { get; set; }
        public ViewerVM Viewer { get; set; }
        //public int IntrestId { get; set; }
        public InterestVM Interest { get; set; }

    }
}