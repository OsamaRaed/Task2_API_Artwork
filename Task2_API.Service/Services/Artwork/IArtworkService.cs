using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Core.DTO;
using Task2_API.Core.ViewModel;

namespace Task2_API.Service.Services.Artwork
{
    public interface IArtworkService
    {
        List<ArtworkVM> Index();
        ArtworkVM Details(int id);
        void Create(CreateArtworkDTO dTO);
        void Update(UpdateArtworkDTO dTO);
        void Delete(int id);
    }
}
