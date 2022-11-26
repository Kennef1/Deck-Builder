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
    public partial class Update_Menu : Form
    {
        #region Constructors
        public Update_Menu(Update_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }
        #endregion Constructors

        #region Loads
        private void Update_Menu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion Loads

        #region Members
        private int i_Selection;
        /* reference to parent code to be changed */
        private Update_Menu_Handler _parent;
        #endregion Members

        #region Methods
        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Update_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (_parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }*/

        }
        #endregion Methods

    }

    public class Update_Menu_Handler
    {
        #region Constructors
        public Update_Menu_Handler()
        {
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create update menu form */
        private Update_Menu form_update_menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;
        #endregion Members

        #region Methods
        public int run()
        {
            while (selection_manager.i_Menu_Option != UserSelectionManager.i_BACK)
            {
                initialise();

                //check for user input to open next level of windows ONLY
                switch (selection_manager.i_Menu_Option)
                {
                    case UserSelectionManager.i_BACK:
                        return_manager.set_status(ReturnManager.USER_EXIT);
                        break;
                    case UserSelectionManager.i_CLOSE:
                        return_manager.set_status(ReturnManager.FORCE_EXIT);
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
            /* reset return status in case it gets set somewhere */
            return_manager.reset();
            selection_manager.reset();
            form_update_menu = new Update_Menu(this);
            //run the form after creating it
            form_update_menu.ShowDialog();
        }
        #endregion Methods

    }

}
