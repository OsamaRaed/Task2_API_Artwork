using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;
using Task2_API.Data;

namespace Task2_API.Service.Services.Artwork
{
    public class ArtworkService : IArtworkService
    {
        private readonly ApplicationDbContext _DB;

        public ArtworkService(ApplicationDbContext DB)
        {
            _DB = DB;
        }

        public List<ArtworkVM> Index()
        {
            return _DB.Artworks.Include(x => x.Category)
                .Include(x => x.Viewers).Select(x => new ArtworkVM(x)).ToList(); 
        }

        public ArtworkVM Details(int id)
        {
            return new ArtworkVM(_DB.Artworks.Include(x => x.Viewers)
                .SingleOrDefault(x => x.Id == id));
        }

        public void Create(CreateArtworkDTO dTO)
        {

        }

        public void Update(UpdateArtworkDTO dTO)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
