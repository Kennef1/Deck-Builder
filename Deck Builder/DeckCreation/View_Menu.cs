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
    public partial class View_Menu : Form
    {
        #region Constructors
        public View_Menu(View_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }
        #endregion Constructors

        #region Loads
        private void View_Menu_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 500);
        }
        #endregion Loads

        #region Members
        private int i_Selection;
        /* reference to parent code to be changed */
        private View_Menu_Handler _parent;
        /* Container to hold the card list being bound to the data grid */
        private BindingList<MTG.MTG_Card> Card_List;
        #endregion Members

        #region Methods
        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void View_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }
        }

        private void Button_View_Click(object sender, EventArgs e)
        {
            Card_List = MTG.JSONManager.read_decklist();

            DataGrid.DataSource = Card_List;
            DataGrid.AutoResizeColumns();
        }

        private void Reposition_Controls(Size size)
        {
            Button_View.Location = new Point(size.Width - 30 - Button_View.Width, size.Height - 50 - Button_View.Size.Height);
            Button_Back.Location = new Point(size.Width - Button_Back.Width - (size.Width - Button_View.Location.X), 
                size.Height - 50 - Button_Back.Size.Height);
            DataGrid.Size = new Size(size.Width - 30, size.Height - 95);
        }

        private void View_Menu_Resize(object sender, EventArgs e)
        {
            Reposition_Controls(this.Size);
        }
        #endregion Methods
    }

    public class View_Menu_Handler
    {
        #region Constructors
        public View_Menu_Handler()
        {
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        /* Create view menu form */
        private View_Menu form_view_menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;
        #endregion Members

        #region Members
        public int run()
        {
            while (check_exit())
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
            form_view_menu = new View_Menu(this);
            //run the form after creating it
            form_view_menu.ShowDialog();
        }

        private bool check_exit()
        {

            return selection_manager.i_Menu_Option != UserSelectionManager.i_BACK
                && !return_manager.is_objective_exit();
        }
        #endregion Members

    }
}
