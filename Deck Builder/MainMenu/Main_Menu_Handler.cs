using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deck_Builder.DeckCreation;
using Deck_Builder.MainMenu;

namespace Deck_Builder
{
    public class MainMenuHandler
    {
        //CONSTRUCTOR
        public MainMenuHandler()
        {
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }

        //MEMBERS
        /* Create main menu form */
        private Main_Menu form_Main_Menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;

        //METHODS
        public int run()
        {
            //Loop the main menu until and exit command is received
            while (selection_manager.i_Menu_Option != UserSelectionManager.i_EXIT)
            {
                initialise();
                
                //check for user input to open next level of windows ONLY
                //  default case breaks application immediately
                switch (selection_manager.i_Menu_Option)
                {
                    case UserSelectionManager.i_CREATE:
                        CreateDecklist_Menu_Handler create_menu = new CreateDecklist_Menu_Handler();
                        //listen for any non-zero return statuses
                        return_manager.set_status(create_menu.run());
                        break;
                    case UserSelectionManager.i_UPDATE:
                        Update_Menu_Handler update_menu = new Update_Menu_Handler();
                        return_manager.set_status(update_menu.run());
                        break;
                    case UserSelectionManager.i_VIEW:
                        View_Menu_Handler view_menu = new View_Menu_Handler();
                        return_manager.set_status(view_menu.run());
                        break;
                    case UserSelectionManager.i_DELETE:
                        Delete_Menu_Handler delete_menu = new Delete_Menu_Handler();
                        return_manager.set_status(delete_menu.run());
                        break;
                    
                    case UserSelectionManager.i_CLOSE:
                        return_manager.set_status(ReturnManager.FORCE_EXIT);
                        break;
                    case UserSelectionManager.i_EXIT: break;
                    default: break;
                }

                //check if form was forcefully closed using the X button
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
            /* reset return status in case it gets set somewhere */
            return_manager.reset();
            selection_manager.reset();
            form_Main_Menu = new Main_Menu(this);
            //run the form after creating it
            form_Main_Menu.ShowDialog();
        }
    }
}
