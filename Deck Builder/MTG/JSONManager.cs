using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Deck_Builder.MTG;
using Deck_Builder.MainMenu;
using Newtonsoft.Json;

/*
    TODO:
    Add a check in the pull_MTG_data method to ceck to see if the card its looking for exists
    If it does not exist then do not create any cards.

    Currently the method will create a basic card that has "null" for every field 
*/

namespace Deck_Builder.MTG
{
    static public class JSONManager
    {
        //CONSTRUCTOR


        //SUBCLASSES
        private class Analysis
        {
            public Analysis()
            {
                name = "";
                layout = "";
            }
            public Analysis(string n, string t)
            {
                name = n;
                layout = t;
            }

            public string name;
            public string layout;
        }

        //MEMBERS
        private static bool b_Cancel = false;

        //METHODS
        /*convert list to json file*/
        public static void push_MTG_data(List<MTG_Card> list)
        {
            Deck_Name_Prompt_Handler deck_name_prompt = new Deck_Name_Prompt_Handler();
            string file_name = deck_name_prompt.run();
            File.WriteAllText("Decks\\" + file_name + ".json", JsonConvert.SerializeObject(list, Formatting.Indented));
        }

        /*pull relevant details from json master file and save to MTG_Card object List, then return
            the operation's status*/
        public static int pull_MTG_data(List<MTG_Card> list)
        {
            initialise();

            //throw up loading screen
            Loading_Screen.ShowLoadingScreen();

            bool b_Next;
            StreamReader reader;
            string line;

            /*System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            string s_Directory = openFileDialog.FileName;*/

            reader = File.OpenText("oracle-cards.json");
            Loading_Screen.InitialiseForm(list.Count);

            //set integer to iterate
            int i = 0;
            while (i < list.Count && !b_Cancel)
            {
                b_Next = false;
                Console.WriteLine(list[i].name);
                //update loading screen
                Loading_Screen.UpdateForm(list[i].name);

                while (!String.IsNullOrEmpty(line = reader.ReadLine()) && !b_Next)
                {
                    Analysis current_check = new Analysis();
                    //check if current line contains the name of the cards
                    //  then remove trailing comma and check if the line are the square bracket lines
                    //  then check if current line has a valid card type (isnt art) then execute
                    if (line.Contains(list[i].name))
                    {
                        if (line[line.Length - 1] == ',')
                            line = line.Remove(line.Length - 1);
                        if (line != "[" && line != "]")
                            current_check = JsonConvert.DeserializeObject<Analysis>(line);
                    }
                    
                    /* this check is required because if the card name exists in the flavour text of a different card
                        first then it will attempt to serialise the wrong card instead */
                    if (current_check.name == list[i].name && MTG_Card.check_valid_layout(current_check.layout))
                    {
                        b_Next = true;
                        switch (current_check.layout)
                        {
                            case MTG_Card.NORMAL:
                                Normal_Card _normal_card = JsonConvert.DeserializeObject<Normal_Card>(line);
                                list[i] = _normal_card;
                                break;
                            case MTG_Card.TRANSFORM:
                                Transform_Card _transform_card = JsonConvert.DeserializeObject<Transform_Card>(line);
                                list[i] = _transform_card;
                                break;
                            case MTG_Card.SPLIT:
                                Split_Card _split_card = JsonConvert.DeserializeObject<Split_Card>(line);
                                list[i] = _split_card;
                                break;
                            case MTG_Card.ADVENTURE:
                                Adventure_Card _adventure_card = JsonConvert.DeserializeObject<Adventure_Card>(line);
                                list[i] = _adventure_card;
                                break;
                            case MTG_Card.MODAL_DFC:
                                MDF_Card _mdf_card = JsonConvert.DeserializeObject<MDF_Card>(line);
                                list[i] = _mdf_card;
                                break;
                            case MTG_Card.LEVELER:
                                Leveler_Card _leveler_card = JsonConvert.DeserializeObject<Leveler_Card>(line);
                                list[i] = _leveler_card;
                                break;
                            case MTG_Card.SAGA:
                                Saga_Card _saga_card = JsonConvert.DeserializeObject<Saga_Card>(line);
                                list[i] = _saga_card;
                                break;
                            case MTG_Card.CLASS:
                                Class_Card _class_card = JsonConvert.DeserializeObject<Class_Card>(line);
                                list[i] = _class_card;
                                break;
                        }
                    }

                    /* immediately return if user presses cancel */
                    if (b_Cancel)
                        return ReturnManager.USER_CANCEL;
                }
                //return to top of file and forget next position
                reader.BaseStream.Position = 0;
                reader.DiscardBufferedData();
                //manually iterate
                i++;
            }

            /*once data has been added, remove all null instances - cards that dont exist*/
            list.RemoveAll(card => card.oracle_id == null);
            Loading_Screen.CloseForm();

            /*prompt user to pick a commander*/
            List<string> list_Legendary_Creatures = new List<string>();
            foreach (MTG_Card card in list)
                if (card.type_line.Contains("Legendary Creature"))
                    list_Legendary_Creatures.Add(card.name);

            Commander_Prompt_Handler commander_prompt = new Commander_Prompt_Handler(list_Legendary_Creatures);
            string commander = commander_prompt.run();

            if (commander != "No Commander")
                list[list.FindIndex(card => card.name == commander)].b_isCommander = true;

            return ReturnManager.OBJECTIVE_EXIT;
        }

        /*read a valid json file of an existing decklist and convert to MTG_Card object List*/
        public static BindingList<MTG_Card> read_decklist()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            string s_Directory = openFileDialog.FileName;

            if (s_Directory == "" || !s_Directory.Contains(".json"))
                return null;

            StreamReader reader = File.OpenText(s_Directory);
            string data = reader.ReadToEnd();

            List<object> o_Card_Data = JsonConvert.DeserializeObject<List<object>>(data);
            List<string> s_Card_Strings = new List<string>();

            foreach (object obj in o_Card_Data)
                s_Card_Strings.Add(obj.ToString());

            // You can also use the amazing line below but I've never used FROM xx IN yy before
            //List<string> s_Card_String = (from o in o_Card_Data select o.ToString()).ToList();

            BindingList<MTG_Card> card_list = new BindingList<MTG_Card>();

            for (int i = 0; i < s_Card_Strings.Count; i++)
            {
                /* this step is pretty inefficient 
                   it can be improved by removing the first deserialise step somehow */
                card_list.Add(JsonConvert.DeserializeObject<MTG_Card>(s_Card_Strings[i]));

                switch (card_list[i].layout)
                {
                    case "normal":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Normal_Card>(s_Card_Strings[i]));
                        break;
                    case "transform":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Transform_Card>(s_Card_Strings[i]));
                        break;
                    case "split":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Split_Card>(s_Card_Strings[i]));
                        break;
                    case "adventure":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Adventure_Card>(s_Card_Strings[i]));
                        break;
                    case "modal_dfc":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<MDF_Card>(s_Card_Strings[i]));
                        break;
                    case "leveler":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Leveler_Card>(s_Card_Strings[i]));
                        break;
                    case "saga":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Saga_Card>(s_Card_Strings[i]));
                        break;
                    case "class":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Class_Card>(s_Card_Strings[i]));
                        break;
                    case "token":
                        card_list.RemoveAt(i);
                        card_list.Insert(i, JsonConvert.DeserializeObject<Token_Card>(s_Card_Strings[i]));
                        break;
                }
            }

            return card_list;
        }

        /*set static parameters to initial values*/
        private static void initialise()
        {
            b_Cancel = false;
        }

        /*public method to let forms cancel operations*/
        public static void cancel_operation()
        {
            b_Cancel = true;
        }
    }
}