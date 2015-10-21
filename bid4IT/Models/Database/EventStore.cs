using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bid4IT.Models.Database {
    class EventStore {
        public int EventStoreId { get; set; }
        public int DefinedEventId { get; set; }
        public string Name { get; set; }
        public int FollowingEvent { get; set; }
    }
}
