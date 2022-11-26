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

namespace Deck_Builder.DeckCreation
{
    public partial class CreateDecklist_Menu : Form
    {
        //CONSTRUCTORS
        public CreateDecklist_Menu(CreateDecklist_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }

        //LOADS
        private void CreateDecklist_Menu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        //MEMBERS
        private int i_Selection;
        /* reference to parent code to be changed */
        private CreateDecklist_Menu_Handler _parent;

        //METHODS
        private void Button_Import_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_IMPORT;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Manual_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_MANUAL;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void CreateDecklist_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (_parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }*/
        }

    }

    public class CreateDecklist_Menu_Handler
    {
        #region Constructors
        public CreateDecklist_Menu_Handler()
        {
            form_Create_Menu = new CreateDecklist_Menu(this);
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create menu form */
        private CreateDecklist_Menu form_Create_Menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;
        #endregion Members

        #region Methods
        public int run()
        {
            while (check_exit())
            {
                initialise();

                switch (selection_manager.i_Menu_Option)
                {
                    case UserSelectionManager.i_IMPORT:
                        Import_Menu_Handler import_menu = new Import_Menu_Handler();
                        return_manager.set_status(import_menu.run());
                        break;
                    case UserSelectionManager.i_MANUAL:
                        Manual_Menu_Handler manual_menu = new Manual_Menu_Handler();
                        return_manager.set_status(manual_menu.run());
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
            //this should porbably be just return status
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
            //i_Menu_Option = -1;
            /* reset return status in case it gets set somehow */
            return_manager.reset();
            selection_manager.reset();
            form_Create_Menu = new CreateDecklist_Menu(this);
            //run the form after creating it
            form_Create_Menu.ShowDialog();
        }

        private bool check_exit()
        {

            return selection_manager.i_Menu_Option != UserSelectionManager.i_BACK
                && !return_manager.is_objective_exit();
        }
        #endregion Methods
    }
}
