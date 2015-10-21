using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bid4IT.Models.Database {
    class Address {
        public int AdressId { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public City City { get; set; }
    }
}
