using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deck_Builder.MTG;

namespace Deck_Builder.MTG
{
    static public class JSONManager
    {
        //CONSTRUCTOR


        //MEMBERS


        //METHODS
        /*convert list to json file*/

        /*pull relevant details from json master file and save to MTG_Card object List*/
        public static void pull_data(List<MTG_Card> list)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            string s_Directory = openFileDialog.FileName;


        }

        /*convert json file to list*/
    }
}
