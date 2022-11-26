using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Builder.MTG
{
    public class MTG_Card
    {
        //CONSTRUCTOR
        public MTG_Card(string n)
        {
            s_Name = n;
            b_isCommander = false;
        }

        //MEMBERS
        public string s_Name;
        public bool b_isCommander;

        //METHODS
    }
}
