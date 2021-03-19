using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;

namespace Task2_API.Service.Services.Viewer
{
    public interface IViewerService
    {
        List<ViewerVM> Index();
        ViewerVM Details(int id);
        void Create(CreateViewerDTO dTO);
        void Update(UpdateViewerDTO dTO);
        void Delete(int id);
    }
}
