using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Deck_Builder.DeckCreation;

namespace Deck_Builder
{
    static class Window_Control
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Decks");

            //create main menu handler and run it
            MainMenuHandler menu = new MainMenuHandler();
            menu.run();

        }
    }
}
