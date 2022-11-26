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
    public partial class Commander_Prompt : Form
    {
        #region Constructors
        public Commander_Prompt(Commander_Prompt_Handler Parent)
        {
            InitializeComponent();
            _parent = Parent;
        }
        #endregion Constructors

        #region Loads
        private void Commander_Prompt_Load(object sender, EventArgs e)
        {
            //listBox_Legendary.Items.Add("something");
            //listBox_Legendary.Items.Add("something else");
            listBox_Legendary.DataSource = _parent._commander_list;
            listBox_Legendary.DisplayMember = "Name";
        }
        #endregion Loads

        #region Members
        /* Reference to parent code to be changed */
        Commander_Prompt_Handler _parent;
        #endregion Members

        #region Methods
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (_parent.update_state(_parent._commander_list[listBox_Legendary.SelectedIndex]))
                Close();
        }
        #endregion Methods
    }

    public class Commander_Prompt_Handler
    {
        #region Constructors
        public Commander_Prompt_Handler(List<string> Commander_List)
        {
            s_Commander_Name = "";
            _commander_list = Commander_List;
            _commander_list.Add("No Commander");
        }
        #endregion Constructors

        #region Members
        private string s_Commander_Name;
        private Commander_Prompt form_commander_prompt;
        public List<string> _commander_list;
        #endregion Members

        #region Methods
        public string run()
        {
            form_commander_prompt = new Commander_Prompt(this);
            form_commander_prompt.ShowDialog();
            return s_Commander_Name;
        }

        public bool update_state(string s)
        {
            s_Commander_Name = s;
            return true;
        }
        #endregion Methods

    }
}
