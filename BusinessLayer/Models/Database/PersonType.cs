using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models.Database {
    public class PersonType {
        public int PersonTypeId { get; set; }
        public string Type { get; set; }
        public string AdditionalInfos { get; set; }
    }
}
