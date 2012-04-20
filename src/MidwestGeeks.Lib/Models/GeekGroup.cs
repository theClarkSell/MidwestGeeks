using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidwestGeeks.Lib.Models
{
    public class GeekGroup
    {
        public String Name { get; set; }
        public String Organizer { get; set; }
        public Address Location { get; set; }
        public IEnumerable<String> Topics { get; set; }
        public String LogoUrl { get; set; }
    }

    public class Address
    {
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
    }
}
