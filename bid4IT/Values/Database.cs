using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace bid4IT.Values {
    class Database {
        public const string Path = "";
        public const string Name = "";

        public static string GetCompleteDatabaseFile() {
            if (Path.Equals("")) {
                return System.IO.Path.Combine(ApplicationData.Current.LocalFolder.Path, Name);
            } else {
                return System.IO.Path.Combine(Path, Name);
            }
        }
    }
}
