using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2_API.Core.DTO
{
    public class UpdateArtworkDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ShowDate { get; set; }
        public int CategoryId { get; set; }

    }
}
