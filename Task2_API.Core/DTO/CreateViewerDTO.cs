﻿using System;
using System.Collections.Generic;

namespace Task2_API.Core.DTO
{
    public class CreateViewerDTO
    {
        public string Name { get; set; }
        public string Email{ get; set; }
        public DateTime RegistryDate { get; set; }
    }
}