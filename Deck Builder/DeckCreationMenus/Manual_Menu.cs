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
    public partial class Manual_Menu : Form
    {
        //CONSTRUCTOR
        public Manual_Menu(Manual_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            _parent = Parent;
        }

        //MEMBERS
        private int i_Selection;
        /* Reference to parent code to be changed */
        private Manual_Menu_Handler _parent;


        private void Button_Success_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_SOMETHING;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Manual_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (_parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }*/
        }
    }
}
