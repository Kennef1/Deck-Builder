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
    public partial class Menu_CreateDecklist : Form
    {
        #region Constructors
        public Menu_CreateDecklist(CreateDecklist_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }
        #endregion Constructors

        #region Loads
        private void Menu_CreateDecklist_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion Loads

        #region Members
        private int i_Selection;
        /* reference to parent code to be changed */
        private CreateDecklist_Menu_Handler _parent;
        #endregion Members

        #region Methods
        private void Button_Import_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_IMPORT;
            if (_parent.UpdateState(i_Selection))
                Close();
        }

        private void Button_Manual_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_MANUAL;
            if (_parent.UpdateState(i_Selection))
                Close();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.UpdateState(i_Selection))
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
        #endregion Methods

    }

    public class CreateDecklist_Menu_Handler
    {
        #region Constructors
        public CreateDecklist_Menu_Handler()
        {
            form_CreateMenu = new Menu_CreateDecklist(this);
            returnManager = new ReturnManager();
            selectionManager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create menu form */
        private Menu_CreateDecklist form_CreateMenu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager returnManager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selectionManager;
        #endregion Members

        #region Methods
        public int Run()
        {
            while (CheckExit())
            {
                Initialise();

                switch (selectionManager.i_Menu_Option)
                {
                    case UserSelectionManager.i_IMPORT:
                        Import_Menu_Handler import_menu = new Import_Menu_Handler();
                        returnManager.set_status(import_menu.run());
                        break;
                    case UserSelectionManager.i_MANUAL:
                        Manual_Menu_Handler manual_menu = new Manual_Menu_Handler();
                        returnManager.set_status(manual_menu.run());
                        break;
                    case UserSelectionManager.i_CLOSE:
                        returnManager.set_status(ReturnManager.FORCE_EXIT);
                        break;
                    case UserSelectionManager.i_BACK:
                        returnManager.set_status(ReturnManager.USER_EXIT);
                        break;
                    default: break;
                }

                if (returnManager.is_forced_exit())
                    return ReturnManager.FORCE_EXIT;
            }
            //this should porbably be just return status
            return ReturnManager.USER_EXIT;
        }

        public bool UpdateState(int input)
        {
            selectionManager.update(input);
            return selectionManager.is_valid_option(input);
        }

        private void Initialise()
        {
            //this method resets the key variables for the run() loop to operate
            //i_Menu_Option = -1;
            /* reset return status in case it gets set somehow */
            returnManager.reset();
            selectionManager.reset();
            form_CreateMenu = new Menu_CreateDecklist(this);
            //run the form after creating it
            form_CreateMenu.ShowDialog();
        }

        private bool CheckExit()
        {

            return selectionManager.i_Menu_Option != UserSelectionManager.i_BACK
                && !returnManager.is_objective_exit();
        }
        #endregion Methods
    }
}
