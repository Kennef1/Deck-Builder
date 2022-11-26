using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Builder.MainMenu
{
    public class UserSelectionManager
    {
        //CONSTRUCTOR
        public UserSelectionManager()
        {
            i_Menu_Option = -1;
            for (int i = 0; i < OPTIONS_LENGTH; i++)
                switch (i + 1)
                {
                    case 1: i_Options.SetValue(i_CLOSE, i); break;
                    case 2: i_Options.SetValue(i_EXIT, i); break;
                    case 3: i_Options.SetValue(i_BACK, i); break;
                    case 4: i_Options.SetValue(i_CREATE, i); break;
                    case 5: i_Options.SetValue(i_UPDATE, i); break;
                    case 6: i_Options.SetValue(i_VIEW, i); break;
                    case 7: i_Options.SetValue(i_DELETE, i); break;
                    case 8: i_Options.SetValue(i_IMPORT, i); break;
                    case 9: i_Options.SetValue(i_MANUAL, i); break;
                    case 10: i_Options.SetValue(i_SOMETHING, i); break;
                }
        }

        //MEMBERS
        public int i_Menu_Option;
        /* Create definitions for external classes */
        public const int i_CLOSE = -1;
        public const int i_EXIT = 1;
        public const int i_BACK = 2;
        public const int i_CREATE = 3;
        public const int i_UPDATE = 4;
        public const int i_VIEW = 5;
        public const int i_DELETE = 6;
        public const int i_IMPORT = 7;
        public const int i_MANUAL = 8;
        public const int i_SOMETHING = 9;
        private const int OPTIONS_LENGTH = 10;
        /* List of valid IDs for user to interact with on screen HARDCODED
                1 - Close app 
                2 - Back
                3 - Create decklist 
                4 - Update existing decklist
                5 - View existing decklist
                6 - Delete existing decklist
                7 - Import from txt file
                8 - Manualy enter decklist
                9 - Something */
        private readonly Array i_Options = Array.CreateInstance(typeof(int), OPTIONS_LENGTH);

        //METHODS
        public void reset()
        {
            i_Menu_Option = i_CLOSE;
        }

        public bool is_valid_option(int x)
        {
            return (Array.BinarySearch(i_Options, x) >= 0);
        }

        public void update(int opt)
        {
            i_Menu_Option = opt;
        }

    }
}
