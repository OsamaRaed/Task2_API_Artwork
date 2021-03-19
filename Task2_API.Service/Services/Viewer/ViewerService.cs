using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _DB.Viewers.Include(x => x.Subscription).Include(x => x.ArtworkViews)
                .ThenInclude(x => x.Artwork).Include(x => x.ViewerIntrests)
                .ThenInclude(x => x.Interest).Select(x => new ViewerVM(x)).ToList();
        }

        public ViewerVM Details(int id)
        { 
            return new ViewerVM(_DB.Viewers.Include(x => x.Subscription).Include(x => x.ArtworkViews)
              .ThenInclude(x => x.Artwork).Include(x => x.ViewerIntrests)
              .ThenInclude(x => x.Interest).SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateViewerDTO dto)
        {
            var Createviewer = new ViewerDbEntity()
            {
                Name = dto.Name,
                RegistryDate = dto.RegistryDate,
                CreatedAt = DateTime.Now
            };
            _DB.Viewers.Add(Createviewer);
            _DB.SaveChanges();
            foreach(int interest in dto.ViewerIntrests)
            {
                var ViewerIntrest = new ViewerInterestDbEntity()
                {
                    ViewerId = interest,
                    InterestId = Createviewer.Id
                };
                _DB.ViewerInterests.Add(ViewerIntrest);
                _DB.SaveChanges();
            }
            foreach (int artwork in dto.ViewerIntrests)
            {
                var artworkView = new ArtworkViewDbEntity()
                {
                    ArtworkId = artwork,
                    ViewerId = Createviewer.Id
                };
                _DB.ArtworkViews.Add(artworkView);
                _DB.SaveChanges();
            }
        }

        public void Update(UpdateViewerDTO dTO)
        {

        }
        public void Delete(int id)
        {
            var viewer = _DB.Viewers.Find(id);
            viewer.IsDelete = true;
            _DB.Viewers.Update(viewer);
            _DB.SaveChanges();
        }
    }
}
