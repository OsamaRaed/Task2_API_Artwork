using System;
using System.Collections.Generic;

namespace Task2_API.Core.DTO
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; }
        public List<int> Interests { get; set; }
        public List<int> Artworks { get; set; }
    }
}
