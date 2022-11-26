using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Builder.MainMenu
{
    public class ReturnManager
    {
        //CONSTRUCTOR
        public ReturnManager()
        {
            STATUS = -1;
        }

        //MEMBERS
        private int STATUS;
        public const int USER_EXIT = 0;
        public const int FORCE_EXIT = 1;
        public const int OBJECTIVE_EXIT = 2;

        //METHODS
        public bool is_forced_exit()
        {
            return STATUS == FORCE_EXIT;
        }

        public bool is_user_exit()
        {
            return STATUS == USER_EXIT;
        }

        public bool is_successful_exit()
        {
            return STATUS == OBJECTIVE_EXIT;
        }

        public void set_status(int stat)
        {
            if (stat == FORCE_EXIT || stat == USER_EXIT)
                STATUS = stat;
        }

        public void reset()
        {
            STATUS = -1;
        }
    }
}
