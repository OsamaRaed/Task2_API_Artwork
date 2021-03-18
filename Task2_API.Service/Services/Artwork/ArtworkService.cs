using System;
using System.Collections.Generic;
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
            return null;
        }

        public ArtworkVM Details(int id)
        {
            return null;
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
