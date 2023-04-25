using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2
{
    internal class ComputerPlayer : Player
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int turn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ComputerPlayer(string name, int id, int turn)
        {
            this.name = name;
            this.id = id;
            this.turn = turn;
        }

    }
}
