using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deck_Builder.MainMenu;
using Deck_Builder.DeckCreation;

namespace Deck_Builder
{
    public partial class Main_Menu : Form
    {
        //CONSTRUCTORS
        public Main_Menu(MainMenuHandler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            this._parent = Parent;
        }

        //LOADS
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        //MEMBERS
        private int i_Selection;
        /* reference to parent code to be changed */
        private MainMenuHandler _parent;

        //METHODS
        private void Button_Create_Click(object sender, EventArgs e)
        {
            //update values in menu handler then close window
            i_Selection = UserSelectionManager.i_CREATE;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            //update values in menu handler then close window
            i_Selection = UserSelectionManager.i_UPDATE;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_View_Click(object sender, EventArgs e)
        {
            //update values in menu handler then close window
            i_Selection = UserSelectionManager.i_VIEW;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            //update values in menu handler then close window
            i_Selection = UserSelectionManager.i_DELETE;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            //update values in menu handler then close window
            i_Selection = UserSelectionManager.i_EXIT;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*changed from _parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE*/
            /*if (_parent.selection_manager.i_Menu_Option != UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }*/
        }
    }

    public class MainMenuHandler
    {
        #region Constructors
        public MainMenuHandler()
        {
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create main menu form */
        private Main_Menu form_Main_Menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;
        #endregion Members

        #region Methods
        public int run()
        {
            //Loop the main menu until and exit command is received
            while (check_quit())
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

        private bool check_quit()
        {
            return selection_manager.i_Menu_Option != UserSelectionManager.i_EXIT;
        }
        #endregion Methods
    }

}
