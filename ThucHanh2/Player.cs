using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2
{
    internal interface Player
    {
        public string name { get; set; }
        public int id { get; set; }
        public int turn { get; set; }

    }
}
