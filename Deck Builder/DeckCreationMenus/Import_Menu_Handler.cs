using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Deck_Builder.MainMenu;
using Deck_Builder.MTG;

namespace Deck_Builder.DeckCreation
{
    public class Import_Menu_Handler
    {
        //CONSTRUCTOR
        public Import_Menu_Handler()
        {
            s_Directory = "";
            is_Valid_Directory = true;
            return_manager = new ReturnManager();
            selection_manager = new UserSelectionManager();
        }

        //MEMBERS
        public string s_Directory;
        private bool is_Valid_Directory { get; set; }
        /* Create import menu form */
        private Import_Menu form_Import_Menu;
        /* Manager for detecting if app was force closed using the X button */
        private ReturnManager return_manager;
        /* Manager for handling user input to forms */
        public UserSelectionManager selection_manager;

        //METHODS
        public int run()
        {
            while (selection_manager.i_Menu_Option != UserSelectionManager.i_BACK)
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

        private void begin_import()
        {
            StreamReader reader = File.OpenText(s_Directory);
            string line;
            int i_Card_Count;
            MTG_Card card;
            List<MTG_Card> DeckList = new List<MTG_Card>();

            while (!String.IsNullOrEmpty(line = reader.ReadLine()) )
            {
                string[] items = line.Split(null, 2);
                i_Card_Count = int.Parse(items[0]);

                for (int i = 0; i < i_Card_Count; i++)
                {
                    card = new MTG_Card(items[1]);
                    DeckList.Add(card);
                }

            }


            Console.WriteLine(DeckList.Count);
            Console.ReadLine();
            return;
        }
    }
}
