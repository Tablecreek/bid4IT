﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models.Database {
    public class City {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Zip { get; set; }
    }
}