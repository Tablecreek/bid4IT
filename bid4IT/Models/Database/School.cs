﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bid4IT.Models.Database {
    class School {
        public int SchoolId { get; set; }
        public int Name { get; set; }
        public Address Address { get; set; }
    }
}
