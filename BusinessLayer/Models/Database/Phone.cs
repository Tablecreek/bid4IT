﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models.Database {
    public class Phone {
        public int PhoneId { get; set; }
        public Person Person { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
    }
}
