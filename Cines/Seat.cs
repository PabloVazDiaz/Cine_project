using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Cines
{
     class Seat:Button
    {
        

        public int Row { get; set; }
        public int Column { get; set; }
        public bool Available { get; set; }
        public bool Reserved { get; set; }

        public Seat()
        {
            Available = true;
            Reserved = false;
        }
    }
}
