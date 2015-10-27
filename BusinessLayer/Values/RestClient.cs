using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace BusinessLayer.Values {
    class RestClient {
        public const string Path = "\\\\192.168.75.10\\Austausch\\Informatik\\Abgaben";
        public const string Name = "bid4IT_db";

        public static string GetCompleteDatabaseFile() {
            if (Path.Equals("")) {
                return System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, Name);
            } else {
                return System.IO.Path.Combine(Path, Name);
            }
        }
    }
}
