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
    //CONSTRUCTORS
    public partial class Import_Menu : Form
    {
        //CONSTRUCTOR
        public Import_Menu(Import_Menu_Handler Parent)
        {
            InitializeComponent();
            i_Selection = -1;
            s_User_Input = "";
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            _parent = Parent;
        }

        //MEMBERS
        private int i_Selection;
        private string s_User_Input;
        /* Reference to parent code to be changed */
        private Import_Menu_Handler _parent;
        /* Import dialog manager */
        private OpenFileDialog openFileDialog;

        //METHODS
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_IMPORT;
            s_User_Input = textBox_Directory.Text;
            if (_parent.update_state(i_Selection, s_User_Input))
                Close();
        }

        private void textBox_Directory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                i_Selection = UserSelectionManager.i_SOMETHING;
                s_User_Input = textBox_Directory.Text;
                if (_parent.update_state(i_Selection, s_User_Input))
                    Close();
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            i_Selection = UserSelectionManager.i_BACK;
            if (_parent.update_state(i_Selection))
                Close();
        }

        private void Import_Menu_Load(object sender, EventArgs e)
        {
            textBox_Directory.Text = _parent.s_Directory;
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBox_Directory.Text = openFileDialog.FileName;
        }

        private void Import_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (_parent.selection_manager.i_Menu_Option == UserSelectionManager.i_CLOSE)
            {
                i_Selection = UserSelectionManager.i_CLOSE;
                _parent.update_state(i_Selection);
            }*/
        }
    }
}
