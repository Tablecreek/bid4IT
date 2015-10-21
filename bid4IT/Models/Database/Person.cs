using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace bid4IT.Models.Database {
    class Person {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public PersonType PersonType { get; set; }
        public BitmapImage Image { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Job Job { get; set; }
        public string Class { get; set; }
        public string SchoolType { get; set; }
        public School School { get; set; }
    }
}
