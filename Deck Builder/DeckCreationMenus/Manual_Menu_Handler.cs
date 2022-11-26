using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deck_Builder.MainMenu;

namespace Deck_Builder.DeckCreation
{
    public class Manual_Menu_Handler
    {
        //CONSTRUCTOR
        public Manual_Menu_Handler()
        {
            form_Manual_Menu = new Manual_Menu(this);
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }

        //MEMBERS
        /* Create menu form */
        private Manual_Menu form_Manual_Menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;

        public int run()
        {
            while (selection_manager.i_Menu_Option != UserSelectionManager.i_BACK)
            {
                initialise();

                switch (selection_manager.i_Menu_Option)
                {
                    case UserSelectionManager.i_SOMETHING:
                        return_manager.set_status(ReturnManager.OBJECTIVE_EXIT);
                        break;
                    case UserSelectionManager.i_CLOSE:
                        return_manager.set_status(ReturnManager.FORCE_EXIT);
                        break;
                    case UserSelectionManager.i_BACK:
                        return_manager.set_status(ReturnManager.USER_EXIT);
                        break;
                    default: break;
                }

                if (return_manager.is_forced_exit())
                    return ReturnManager.FORCE_EXIT;
            }
            return ReturnManager.USER_EXIT;
        }

        public bool update_state(int input)
        {
            selection_manager.update(input);
            return selection_manager.is_valid_option(input);
        }

        private void initialise()
        {
            //this method resets the key variables for the run() loop to operate
            /* reset return status in case it gets set somehow */
            return_manager.reset();
            selection_manager.reset();
            form_Manual_Menu = new Manual_Menu(this);
            //run the form after creating it
            form_Manual_Menu.ShowDialog();
        }

    }
}
