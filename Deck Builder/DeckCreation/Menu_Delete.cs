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
    public partial class Menu_Delete : Form
    {
        #region Constructors
        public Menu_Delete(Delete_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }
        #endregion Constructors

        #region Loads
        private void Delete_Menu_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion Loads

        #region Members
        private int i_Selection;
        /* reference to parent code to be changed */
        private Delete_Menu_Handler _parent;
        #endregion Members

        #region Methods
        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.UpdateState(i_Selection))
                Close();
        }
        #endregion Methods

    }

    public class Delete_Menu_Handler
    {
        #region Constructors
        public Delete_Menu_Handler()
        {
            returnManager = new ReturnManager();
            selectionManager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create delete menu form */
        private Menu_Delete form_DeleteMenu;
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

                //check for user input to open next level of windows ONLY
                switch (selectionManager.i_Menu_Option)
                {
                    case UserSelectionManager.i_BACK:
                        returnManager.set_status(ReturnManager.USER_EXIT);
                        break;
                    case UserSelectionManager.i_CLOSE:
                        returnManager.set_status(ReturnManager.FORCE_EXIT);
                        break;
                    default: break;
                }
                if (returnManager.is_forced_exit())
                    return ReturnManager.FORCE_EXIT;
            }

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
            /* reset return status in case it gets set somewhere */
            returnManager.reset();
            selectionManager.reset();
            form_DeleteMenu = new Menu_Delete(this);
            //run the form after creating it
            form_DeleteMenu.ShowDialog();
        }

        private bool CheckExit()
        {
            return selectionManager.i_Menu_Option != UserSelectionManager.i_BACK
                && !returnManager.is_objective_exit();
        }
        #endregion Methods

    }

}
