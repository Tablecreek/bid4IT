using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bid4IT.Models.Database {
    class EventTrigger {
        public int EventTriggerId { get; set; }
        public ContactType ContactType { get; set; }
        public string ContactValue { get; set; }
    }
}
