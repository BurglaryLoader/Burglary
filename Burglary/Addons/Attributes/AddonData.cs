using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burglary.Addons.Attributes
{
    public class AddonData : Attribute
    {
        //constructor. obviously
        public AddonData(string Name="Addon", string Description="", string Author="Author", string Version="1.0.0") {
            name = Name;
            description = Description;
            author = Author;
            version = Version;
        }

        //real protected properties
        protected string name { get; set; }
        protected string description { get; set; }
        protected string author { get; set; }
        protected string version { get; set; }


        //public gets
        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public string Author { get { return author; } }
        public string Version { get { return version; } }
    }
}
