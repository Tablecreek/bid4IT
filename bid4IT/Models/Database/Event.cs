using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bid4IT.Models.Database {
    class Event {
        public int EventId { get; set; }
        public EventStore DefinedEvent { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
        public EventTrigger EventTrigger { get; set; }
        public Person Applicant { get; set; }
        public EventState EventState { get; set; }
        public int AdditionalDocumentId { get; set; }
        public Person PersonInCharge { get; set; }
    }
}
