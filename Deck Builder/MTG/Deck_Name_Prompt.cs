using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck_Builder.MTG
{
    public partial class Deck_Name_Prompt : Form
    {
        #region Constructors
        public Deck_Name_Prompt(Deck_Name_Prompt_Handler Parent)
        {
            InitializeComponent();
            _parent = Parent;
            s_User_Input = "";
        }
        #endregion Constructors

        //MEMBERS
        private string s_User_Input;
        /* Reference to parent code to be changed */
        Deck_Name_Prompt_Handler _parent;


        //METHODS
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (_parent.update_state(TextBox_SetName.Text))
                Close();
        }

        private void TextBox_SetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (_parent.update_state(TextBox_SetName.Text))
                    Close();
        }

        private void TextBox_SetName_Enter(object sender, EventArgs e)
        {
            TextBox_SetName.Clear();
        }

        //LOADS
        private void Deck_Name_Prompt_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }

    public class Deck_Name_Prompt_Handler
    {
        //CONSTRUCTOR
        public Deck_Name_Prompt_Handler()
        {
            s_File_Name = "UNNAMED_DECK";
        }

        //MEMBERS
        private string s_File_Name;
        private Deck_Name_Prompt form_User_Prompt;

        //METHODS
        public string run()
        {
            form_User_Prompt = new Deck_Name_Prompt(this);
            form_User_Prompt.ShowDialog();
            return s_File_Name;
        }

        public bool update_state(string s)
        {
            s_File_Name = s;
            return true;
        }
    }
}
