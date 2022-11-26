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

        //MEMBERS
        private int i_Selection;
        /* reference to parent code to be changed */
        private MainMenuHandler _parent;

        //METHODS
        private void Form1_Load(object sender, EventArgs e) { }

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
}
