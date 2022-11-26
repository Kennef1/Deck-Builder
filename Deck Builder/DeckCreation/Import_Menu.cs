using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deck_Builder.MainMenu;
using Deck_Builder.MTG;


namespace Deck_Builder.DeckCreation
{
    public partial class Import_Menu : Form
    {
        #region Constructors
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
        #endregion Constructors

        #region Loads
        private void Import_Menu_Load(object sender, EventArgs e)
        {
            textBox_Directory.Text = _parent.s_Directory;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion Loads

        #region Members
        private int i_Selection;
        private string s_User_Input;
        /* Reference to parent code to be changed */
        private Import_Menu_Handler _parent;
        /* Import dialog manager */
        private OpenFileDialog openFileDialog;
        #endregion Members

        #region Methods
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
        #endregion Methods
    }

    public class Import_Menu_Handler
    {
        #region Constructors
        public Import_Menu_Handler()
        {
            s_Directory = "";
            is_Valid_Directory = true;
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }
        #endregion Constructors

        #region Members
        public string s_Directory;
        private bool is_Valid_Directory { get; set; }
        /* Create import menu form */
        private Import_Menu form_Import_Menu;
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
                        begin_import();
                        return_manager.set_status(ReturnManager.OBJECTIVE_EXIT);
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

            //only two options posible here -> successful exit or user exit
            if (return_manager.is_objective_exit())
                return ReturnManager.OBJECTIVE_EXIT;

            return ReturnManager.USER_EXIT;
        }

        //overloaded update state method
        public bool update_state(int input, string directory)
        {
            s_Directory = directory;
            selection_manager.update(input);
            return selection_manager.is_valid_option(input);
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
            form_Import_Menu = new Import_Menu(this);
            //run the form after creating it
            form_Import_Menu.ShowDialog();
        }

        private bool check_valid_directory(string s)
        {
            return is_Valid_Directory = Directory.Exists(s);
        }

        private bool check_exit()
        {

            return selection_manager.i_Menu_Option != UserSelectionManager.i_BACK
                && !return_manager.is_objective_exit();
        }

        private void begin_import()
        {

            StreamReader reader = File.OpenText(s_Directory);
            string line;
            int i_Card_Count;
            MTG_Card card;
            List<MTG_Card> DeckList = new List<MTG_Card>();

            while (!String.IsNullOrEmpty(line = reader.ReadLine()))
            {
                string[] items = line.Split(null, 2);
                i_Card_Count = int.Parse(items[0]);

                for (int i = 0; i < i_Card_Count; i++)
                {
                    card = new MTG_Card(items[1]);
                    DeckList.Add(card);
                }
            }

            //create return manager to handle all operation outcomes
            ReturnManager return_manager = new ReturnManager();
            return_manager.set_status(JSONManager.pull_MTG_data(DeckList));

            //Only create the decklist if the outcome was successful
            if(return_manager.is_objective_exit())
            {
                JSONManager.push_MTG_data(DeckList);
            }

            return;
        }
        #endregion Methods
    }
}
