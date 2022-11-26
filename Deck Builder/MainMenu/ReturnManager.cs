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
            for (int i = 0; i < OPTIONS_LENGTH; i++)
                switch (i + 1)
                {
                    case 1: i_Options.SetValue(USER_EXIT, i); break;
                    case 2: i_Options.SetValue(FORCE_EXIT, i); break;
                    case 3: i_Options.SetValue(OBJECTIVE_EXIT, i); break;
                }
        }

        //MEMBERS
        private int STATUS;
        public const int USER_EXIT = 0;
        public const int FORCE_EXIT = 1;
        public const int OBJECTIVE_EXIT = 2;
        public const int USER_CANCEL = 3;
        private const int OPTIONS_LENGTH = 4;
        /* List of valid return statuses
            0 - USER_EXIT: user presses back button
            1 - FORCE_EXIT: user presses X to close window
            2 - OBJECTIVE_EXIT: routine has successfully completed
            3 - USER_CANCEL: user presses cancel */
        private readonly Array i_Options = Array.CreateInstance(typeof(int), OPTIONS_LENGTH);

        //METHODS
        public bool is_forced_exit()
        {
            return STATUS == FORCE_EXIT;
        }

        public bool is_user_exit()
        {
            return STATUS == USER_EXIT;
        }

        public bool is_objective_exit()
        {
            return STATUS == OBJECTIVE_EXIT;
        }

        public bool is_user_cancel()
        {
            return STATUS == USER_CANCEL;
        }

        public void set_status(int stat)
        {
            if (is_valid_option(stat))
                STATUS = stat;
        }

        public void reset()
        {
            STATUS = -1;
        }

        private bool is_valid_option(int x)
        {
            return (Array.BinarySearch(i_Options, x) >= 0);
        }

    }
}
