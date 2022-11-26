using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Deck_Builder.MTG
{
    public class MTG_Card
    {
        //CONSTRUCTOR
        public MTG_Card(string n)
        {
            name = n;
        }

        //MEMBERS
        [JsonProperty(Order = -2)] public string oracle_id;
        [JsonProperty(Order = -2)] public string name { get; set; }
        [JsonProperty(Order = -2)] public string type_line { get; set; }
        [JsonProperty(Order = -2)] public float power, toughness;
        [JsonProperty(Order = -2)] public bool b_isCommander { get; set; } = false;
        [JsonProperty(Order = -2)] public float cmc;
        [JsonProperty(Order = -2)] public string mana_cost;
        [JsonProperty(Order = -2)] public List<string> colors;
        [JsonProperty(Order = -2)] public string layout { get; set; }

        //STATIC MEMBERS
        public const string NORMAL = "normal";
        public const string TRANSFORM = "transform";
        public const string SPLIT = "split";
        public const string ADVENTURE = "adventure";
        public const string MODAL_DFC = "modal_dfc";
        public const string LEVELER = "leveler";
        public const string SAGA = "saga";
        public const string CLASS = "class";
        public const string FLIP = "flip";
        public const string TOKEN = "token";
        public static List<string> CARD_TYPES = new List<string>()
            { "normal", "transform", "split", "adventure", "modal_dfc", "leveler", "saga", "flip", "class", "token" };

        //METHODS
        public static bool check_valid_layout(string t)
        {
            return CARD_TYPES.Contains(t);
        }
    }

    //BELOW ARE ADDITIONAL CLASSES TO ENCAPSULATE THE DIFFERENT LAYOUTS OF EACH MTG CARD
    // AND WILL INHERIT THE BASE CLASS MTG_Card
    /* Class for normal MTG cards, may not have any differences from base MTG_Card */
    public class Normal_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Normal_Card(string n) : base(n)
        {

        }
    }
    /* Class for cards that transform like werewolf/vampire cards */
    public class Transform_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Transform_Card(string n) : base(n)
        {

        }
        public List<Card_Face> card_faces = new List<Card_Face>();
    }
    /* Class for cards the have two spells compressed into one, like Wear // Tear*/
    public class Split_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Split_Card(string n) : base(n)
        {

        }

        //MEMBERS
        public List<Card_Face> card_faces = new List<Card_Face>();
    }
    /* Class for adventure cards such as Lovestruck Beast */
    public class Adventure_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Adventure_Card(string n) : base(n)
        {

        }
        public List<Card_Face> card_faces = new List<Card_Face>();
    }
    /* Class for Modal Dual Faced Cards such as Birgi God of Storytelling */
    public class MDF_Card : MTG_Card
    {
        //CONSTRUCTOR
        public MDF_Card(string n) : base(n)
        {

        }

        //MEMBERS
        public List<Card_Face> card_faces = new List<Card_Face>();
    }
    /* Class for cards that have level up abilities such as Joraga Treespeaker */
    public class Leveler_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Leveler_Card(string n) : base(n)
        {

        }
    }
    /* Class for Saga cards such as Urza's Saga */
    public class Saga_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Saga_Card(string n) : base(n)
        {

        }
    }
    /* Class for cards that may flip to become something else such as Akki Lavarunner // Tok-Tok, Volcano Born */
    public class Flip_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Flip_Card(string n) : base(n)
        {

        }
        public List<Card_Face> card_faces = new List<Card_Face>();
    }
    /* Class for class cards such as Druid Class */
    public class Class_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Class_Card(string n) : base(n)
        {

        }
    }
    /* Class for Tokens (may not get used) */
    public class Token_Card : MTG_Card
    {
        //CONSTRUCTOR
        public Token_Card(string n) : base(n)
        {

        }
    }

    //BELOW IS A HELPER CLASS TO ENCAPSULATE INFORMATION FOR CARD FACES
    public class Card_Face
    {
        //CONSTRUCTOR
        public Card_Face()
        {

        }

        public string name;
        public string type_line;
        public string power, toughness;
        public float cmc;
        public string mana_cost;
        public List<string> colors;

    }
}
