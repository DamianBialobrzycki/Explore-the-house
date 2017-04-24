using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore_the_house
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "Widzisz tutaj " + decoration + ".";
            }
        }
    }
}
