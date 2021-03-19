using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;
using Task2_API.Data.Models;

namespace Task2_API.Service.Services.Viewer
{
    public class ViewerService : IViewerService
    {
        private readonly ApplicationDbContext _DB;
        public ViewerService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<ViewerVM> Index()
        {
            return null;
        }

        public ViewerVM Details(int id)
        {
            return null;
        }

        public void Create(CreateViewerDTO dto)
        {
            var viewer = new ViewerDbEntity();
            viewer.Name = dto.Name;
            viewer.Email = dto.Email;
            viewer.RegistryDate = dto.RegistryDate;
            viewer.CreatedAt = DateTime.Now;
            _DB.Viewers.Add(viewer);
            _DB.SaveChanges();
        }

        public void Update(UpdateViewerDTO dTO)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
