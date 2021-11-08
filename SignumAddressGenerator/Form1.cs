
using System;
using System.Drawing;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Linq;

namespace SignumAddressGenerator
{
    public partial class Form1 : Form
    {
        private delegate void DFound(string Address, string Pass, string ID);
        private delegate void DError();

        private bool running;
        private bool wordsUsecheck;
        private string AddressToFind = "";
        private int NrofChars;
        private int NrofCharsMin;
        private long Tested;
        private object LockObj = new();
        private long counter;
        private long lastval;
        private string? SRS_Node = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                GroupAddress.Enabled = false;
                GroupOptions.Enabled = false;
                comboBox1.Enabled = false;
                btnSave.Enabled = false;
                txtAddress.Clear();
                txtPass.Clear();
                txtAcct.Clear();

                lblGenStatus.ForeColor = Color.Green;
                lblGenStatus.Text = "Generating Addresses, looking for match!";
                

                Tested = 0;
                counter = 0;
                lastval = 0;
                AddressToFind = txtFind1.Text + "-" + txtFind2.Text + "-" + txtFind3.Text + "-" + txtFind4.Text;
                AddressToFind = AddressToFind.Replace("@", ".");
                NrofChars = Convert.ToInt32(nrPass.Value);
                NrofCharsMin = Convert.ToInt32(nrPassMin.Value);
                wordsUsecheck = UseWords.Checked;
                Thread trda;
                running = true;
                for (var x = 1; x <= (int)nrThreads.Value; x++)
                {
                    trda = new Thread(VanityGeneration)
                    {
                        IsBackground = true
                    };
                    trda.Start(textSeed.Text);
                }
                //trda = null/* TODO Change to default(_) if this is not a reference type */;
                btnStart.Text = "Stop";
                tmr.Enabled = true;
                return;
            }
            if (btnStart.Text == "Stop")
            {
                running = false;
                btnStart.Text = "Start";
                tmr.Enabled = false;
                btnSave.Enabled = true;
                GroupOptions.Enabled = true;
                GroupAddress.Enabled = true;
                comboBox1.Enabled = true;
                lblGenStatus.ForeColor = Color.Red;
                lblGenStatus.Text = "User Stopped Generation Efforts";

            }
        }

        private void VanityGeneration(object? seedText)
        {
            string AccountAddress;
            string AccountID;
            StringBuilder KeySeed = new(NrofChars);
            byte[] PrivateKey;
            byte[] PublicKey;
            byte[] PublicKeyHash;
            SHA256 cSHA256 = SHA256.Create();
            var toFindPattern = new Regex(AddressToFind);
            byte[] b;
            int x;
            int charlength;


            string[] chars = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int TotalChars = chars.Length;
            string[] words = new[] { "like", "just", "love", "know", "never", "want", "time", "out", "there", "make", "look", "eye", "down", "only", "think", "heart", "back", "then", "into", "about", "more", "away", "still", "them", "take", "thing", "even", "through", "long", "always", "world", "too", "friend", "tell", "try", "hand", "thought", "over", "here", "other", "need", "smile", "again", "much", "cry", "been", "night", "ever", "little", "said", "end", "some", "those", "around", "mind", "people", "girl", "leave", "dream", "left", "turn", "myself", "give", "nothing", "really", "off", "before", "something", "find", "walk", "wish", "good", "once", "place", "ask", "stop", "keep", "watch", "seem", "everything", "wait", "got", "yet", "made", "remember", "start", "alone", "run", "hope", "maybe", "believe", "body", "hate", "after", "close", "talk", "stand", "own", "each", "hurt", "help", "home", "god", "soul", "new", "many", "two", "inside", "should", "true", "first", "fear", "mean", "better", "play", "another", "gone", "change", "use", "wonder", "someone", "hair", "cold", "open", "best", "any", "behind", "happen", "water", "dark", "laugh", "stay", "forever", "name", "work", "show", "sky", "break", "came", "deep", "door", "put", "black", "together", "upon", "happy", "such", "great", "white", "matter", "fill", "past", "please", "burn", "cause", "enough", "touch", "moment", "soon", "voice", "scream", "anything", "stare", "sound", "red", "everyone", "hide", "kiss", "truth", "death", "beautiful", "mine", "blood", "broken", "very", "pass", "next", "forget", "tree", "wrong", "air", "mother", "understand", "lip", "hit", "wall", "memory", "sleep", "free", "high", "realize", "school", "might", "skin", "sweet", "perfect", "blue", "kill", "breath", "dance", "against", "fly", "between", "grow", "strong", "under", "listen", "bring", "sometimes", "speak", "pull", "person", "become", "family", "begin", "ground", "real", "small", "father", "sure", "feet", "rest", "young", "finally", "land", "across", "today", "different", "guy", "line", "fire", "reason", "reach", "second", "slowly", "write", "eat", "smell", "mouth", "step", "learn", "three", "floor", "promise", "breathe", "darkness", "push", "earth", "guess", "save", "song", "above", "along", "both", "color", "house", "almost", "sorry", "anymore", "brother", "okay", "dear", "game", "fade", "already", "apart", "warm", "beauty", "heard", "notice", "question", "shine", "began", "piece", "whole", "shadow", "secret", "street", "within", "finger", "point", "morning", "whisper", "child", "moon", "green", "story", "glass", "kid", "silence", "since", "soft", "yourself", "empty", "shall", "angel", "answer", "baby", "bright", "dad", "path", "worry", "hour", "drop", "follow", "power", "war", "half", "flow", "heaven", "act", "chance", "fact", "least", "tired", "children", "near", "quite", "afraid", "rise", "sea", "taste", "window", "cover", "nice", "trust", "lot", "sad", "cool", "force", "peace", "return", "blind", "easy", "ready", "roll", "rose", "drive", "held", "music", "beneath", "hang", "mom", "paint", "emotion", "quiet", "clear", "cloud", "few", "pretty", "bird", "outside", "paper", "picture", "front", "rock", "simple", "anyone", "meant", "reality", "road", "sense", "waste", "bit", "leaf", "thank", "happiness", "meet", "men", "smoke", "truly", "decide", "self", "age", "book", "form", "alive", "carry", "escape", "damn", "instead", "able", "ice", "minute", "throw", "catch", "leg", "ring", "course", "goodbye", "lead", "poem", "sick", "corner", "desire", "known", "problem", "remind", "shoulder", "suppose", "toward", "wave", "drink", "jump", "woman", "pretend", "sister", "week", "human", "joy", "crack", "grey", "pray", "surprise", "dry", "knee", "less", "search", "bleed", "caught", "clean", "embrace", "future", "king", "son", "sorrow", "chest", "hug", "remain", "sat", "worth", "blow", "daddy", "final", "parent", "tight", "also", "create", "lonely", "safe", "cross", "dress", "evil", "silent", "bone", "fate", "perhaps", "anger", "class", "scar", "snow", "tiny", "tonight", "continue", "control", "dog", "edge", "mirror", "month", "suddenly", "comfort", "given", "loud", "quickly", "gaze", "plan", "rush", "stone", "town", "battle", "ignore", "spirit", "stood", "stupid", "yours", "brown", "build", "dust", "hey", "kept", "pay", "phone", "twist", "although", "ball", "beyond", "hidden", "nose", "taken", "fail", "float", "pure", "somehow", "wash", "wrap", "angry", "cheek", "creature", "forgotten", "heat", "rip", "single", "space", "special", "weak", "whatever", "yell", "anyway", "blame", "job", "choose", "country", "curse", "drift", "echo", "figure", "grew", "laughter", "neck", "suffer", "worse", "yeah", "disappear", "foot", "forward", "knife", "mess", "somewhere", "stomach", "storm", "beg", "idea", "lift", "offer", "breeze", "field", "five", "often", "simply", "stuck", "win", "allow", "confuse", "enjoy", "except", "flower", "seek", "strength", "calm", "grin", "gun", "heavy", "hill", "large", "ocean", "shoe", "sigh", "straight", "summer", "tongue", "accept", "crazy", "everyday", "exist", "grass", "mistake", "sent", "shut", "surround", "table", "ache", "brain", "destroy", "heal", "nature", "shout", "sign", "stain", "choice", "doubt", "glance", "glow", "mountain", "queen", "stranger", "throat", "tomorrow", "city", "either", "fish", "flame", "rather", "shape", "spin", "spread", "ash", "distance", "finish", "image", "imagine", "important", "nobody", "shatter", "warmth", "became", "feed", "flesh", "funny", "lust", "shirt", "trouble", "yellow", "attention", "bare", "bite", "money", "protect", "amaze", "appear", "born", "choke", "completely", "daughter", "fresh", "friendship", "gentle", "probably", "six", "deserve", "expect", "grab", "middle", "nightmare", "river", "thousand", "weight", "worst", "wound", "barely", "bottle", "cream", "regret", "relationship", "stick", "test", "crush", "endless", "fault", "itself", "rule", "spill", "art", "circle", "join", "kick", "mask", "master", "passion", "quick", "raise", "smooth", "unless", "wander", "actually", "broke", "chair", "deal", "favorite", "gift", "note", "number", "sweat", "box", "chill", "clothes", "lady", "mark", "park", "poor", "sadness", "tie", "animal", "belong", "brush", "consume", "dawn", "forest", "innocent", "pen", "pride", "stream", "thick", "clay", "complete", "count", "draw", "faith", "press", "silver", "struggle", "surface", "taught", "teach", "wet", "bless", "chase", "climb", "enter", "letter", "melt", "metal", "movie", "stretch", "swing", "vision", "wife", "beside", "crash", "forgot", "guide", "haunt", "joke", "knock", "plant", "pour", "prove", "reveal", "steal", "stuff", "trip", "wood", "wrist", "bother", "bottom", "crawl", "crowd", "fix", "forgive", "frown", "grace", "loose", "lucky", "party", "release", "surely", "survive", "teacher", "gently", "grip", "speed", "suicide", "travel", "treat", "vein", "written", "cage", "chain", "conversation", "date", "enemy", "however", "interest", "million", "page", "pink", "proud", "sway", "themselves", "winter", "church", "cruel", "cup", "demon", "experience", "freedom", "pair", "pop", "purpose", "respect", "shoot", "softly", "state", "strange", "bar", "birth", "curl", "dirt", "excuse", "lord", "lovely", "monster", "order", "pack", "pants", "pool", "scene", "seven", "shame", "slide", "ugly", "among", "blade", "blonde", "closet", "creek", "deny", "drug", "eternity", "gain", "grade", "handle", "key", "linger", "pale", "prepare", "swallow", "swim", "tremble", "wheel", "won", "cast", "cigarette", "claim", "college", "direction", "dirty", "gather", "ghost", "hundred", "loss", "lung", "orange", "present", "swear", "swirl", "twice", "wild", "bitter", "blanket", "doctor", "everywhere", "flash", "grown", "knowledge", "numb", "pressure", "radio", "repeat", "ruin", "spend", "unknown", "buy", "clock", "devil", "early", "false", "fantasy", "pound", "precious", "refuse", "sheet", "teeth", "welcome", "add", "ahead", "block", "bury", "caress", "content", "depth", "despite", "distant", "marry", "purple", "threw", "whenever", "bomb", "dull", "easily", "grasp", "hospital", "innocence", "normal", "receive", "reply", "rhyme", "shade", "someday", "sword", "toe", "visit", "asleep", "bought", "center", "consider", "flat", "hero", "history", "ink", "insane", "muscle", "mystery", "pocket", "reflection", "shove", "silently", "smart", "soldier", "spot", "stress", "train", "type", "view", "whether", "bus", "energy", "explain", "holy", "hunger", "inch", "magic", "mix", "noise", "nowhere", "prayer", "presence", "shock", "snap", "spider", "study", "thunder", "trail", "admit", "agree", "bag", "bang", "bound", "butterfly", "cute", "exactly", "explode", "familiar", "fold", "further", "pierce", "reflect", "scent", "selfish", "sharp", "sink", "spring", "stumble", "universe", "weep", "women", "wonderful", "action", "ancient", "attempt", "avoid", "birthday", "branch", "chocolate", "core", "depress", "drunk", "especially", "focus", "fruit", "honest", "match", "palm", "perfectly", "pillow", "pity", "poison", "roar", "shift", "slightly", "thump", "truck", "tune", "twenty", "unable", "wipe", "wrote", "coat", "constant", "dinner", "drove", "egg", "eternal", "flight", "flood", "frame", "freak", "gasp", "glad", "hollow", "motion", "peer", "plastic", "root", "screen", "season", "sting", "strike", "team", "unlike", "victim", "volume", "warn", "weird", "attack", "await", "awake", "built", "charm", "crave", "despair", "fought", "grant", "grief", "horse", "limit", "message", "ripple", "sanity", "scatter", "serve", "split", "string", "trick", "annoy", "blur", "boat", "brave", "clearly", "cling", "connect", "fist", "forth", "imagination", "iron", "jock", "judge", "lesson", "milk", "misery", "nail", "naked", "ourselves", "poet", "possible", "princess", "sail", "size", "snake", "society", "stroke", "torture", "toss", "trace", "wise", "bloom", "bullet", "cell", "check", "cost", "darling", "during", "footstep", "fragile", "hallway", "hardly", "horizon", "invisible", "journey", "midnight", "mud", "nod", "pause", "relax", "shiver", "sudden", "value", "youth", "abuse", "admire", "blink", "breast", "bruise", "constantly", "couple", "creep", "curve", "difference", "dumb", "emptiness", "gotta", "honor", "plain", "planet", "recall", "rub", "ship", "slam", "soar", "somebody", "tightly", "weather", "adore", "approach", "bond", "bread", "burst", "candle", "coffee", "cousin", "crime", "desert", "flutter", "frozen", "grand", "heel", "hello", "language", "level", "movement", "pleasure", "powerful", "random", "rhythm", "settle", "silly", "slap", "sort", "spoken", "steel", "threaten", "tumble", "upset", "aside", "awkward", "bee", "blank", "board", "button", "card", "carefully", "complain", "crap", "deeply", "discover", "drag", "dread", "effort", "entire", "fairy", "giant", "gotten", "greet", "illusion", "jeans", "leap", "liquid", "march", "mend", "nervous", "nine", "replace", "rope", "spine", "stole", "terror", "accident", "apple", "balance", "boom", "childhood", "collect", "demand", "depression", "eventually", "faint", "glare", "goal", "group", "honey", "kitchen", "laid", "limb", "machine", "mere", "mold", "murder", "nerve", "painful", "poetry", "prince", "rabbit", "shelter", "shore", "shower", "soothe", "stair", "steady", "sunlight", "tangle", "tease", "treasure", "uncle", "begun", "bliss", "canvas", "cheer", "claw", "clutch", "commit", "crimson", "crystal", "delight", "doll", "existence", "express", "fog", "football", "gay", "goose", "guard", "hatred", "illuminate", "mass", "math", "mourn", "rich", "rough", "skip", "stir", "student", "style", "support", "thorn", "tough", "yard", "yearn", "yesterday", "advice", "appreciate", "autumn", "bank", "beam", "bowl", "capture", "carve", "collapse", "confusion", "creation", "dove", "feather", "girlfriend", "glory", "government", "harsh", "hop", "inner", "loser", "moonlight", "neighbor", "neither", "peach", "pig", "praise", "screw", "shield", "shimmer", "sneak", "stab", "subject", "throughout", "thrown", "tower", "twirl", "wow", "army", "arrive", "bathroom", "bump", "cease", "cookie", "couch", "courage", "dim", "guilt", "howl", "hum", "husband", "insult", "led", "lunch", "mock", "mostly", "natural", "nearly", "needle", "nerd", "peaceful", "perfection", "pile", "price", "remove", "roam", "sanctuary", "serious", "shiny", "shook", "sob", "stolen", "tap", "vain", "void", "warrior", "wrinkle", "affection", "apologize", "blossom", "bounce", "bridge", "cheap", "crumble", "decision", "descend", "desperately", "dig", "dot", "flip", "frighten", "heartbeat", "huge", "lazy", "lick", "odd", "opinion", "process", "puzzle", "quietly", "retreat", "score", "sentence", "separate", "situation", "skill", "soak", "square", "stray", "taint", "task", "tide", "underneath", "veil", "whistle", "anywhere", "bedroom", "bid", "bloody", "burden", "careful", "compare", "concern", "curtain", "decay", "defeat", "describe", "double", "dreamer", "driver", "dwell", "evening", "flare", "flicker", "grandma", "guitar", "harm", "horrible", "hungry", "indeed", "lace", "melody", "monkey", "nation", "object", "obviously", "rainbow", "salt", "scratch", "shown", "shy", "stage", "stun", "third", "tickle", "useless", "weakness", "worship", "worthless", "afternoon", "beard", "boyfriend", "bubble", "busy", "certain", "chin", "concrete", "desk", "diamond", "doom", "drawn", "due", "felicity", "freeze", "frost", "garden", "glide", "harmony", "hopefully", "hunt", "jealous", "lightning", "mama", "mercy", "peel", "physical", "position", "pulse", "punch", "quit", "rant", "respond", "salty", "sane", "satisfy", "savior", "sheep", "slept", "social", "sport", "tuck", "utter", "valley", "wolf", "aim", "alas", "alter", "arrow", "awaken", "beaten", "belief", "brand", "ceiling", "cheese", "clue", "confidence", "connection", "daily", "disguise", "eager", "erase", "essence", "everytime", "expression", "fan", "flag", "flirt", "foul", "fur", "giggle", "glorious", "ignorance", "law", "lifeless", "measure", "mighty", "muse", "north", "opposite", "paradise", "patience", "patient", "pencil", "petal", "plate", "ponder", "possibly", "practice", "slice", "spell", "stock", "strife", "strip", "suffocate", "suit", "tender", "tool", "trade", "velvet", "verse", "waist", "witch", "aunt", "bench", "bold", "cap", "certainly", "click", "companion", "creator", "dart", "delicate", "determine", "dish", "dragon", "drama", "drum", "dude", "everybody", "feast", "forehead", "former", "fright", "fully", "gas", "hook", "hurl", "invite", "juice", "manage", "moral", "possess", "raw", "rebel", "royal", "scale", "scary", "several", "slight", "stubborn", "swell", "talent", "tea", "terrible", "thread", "torment", "trickle", "usually", "vast", "violence", "weave", "acid", "agony", "ashamed", "awe", "belly", "blend", "blush", "character", "cheat", "common", "company", "coward", "creak", "danger", "deadly", "defense", "define", "depend", "desperate", "destination", "dew", "duck", "dusty", "embarrass", "engine", "example", "explore", "foe", "freely", "frustrate", "generation", "glove", "guilty", "health", "hurry", "idiot", "impossible", "inhale", "jaw", "kingdom", "mention", "mist", "moan", "mumble", "mutter", "observe", "ode", "pathetic", "pattern", "pie", "prefer", "puff", "rape", "rare", "revenge", "rude", "scrape", "spiral", "squeeze", "strain", "sunset", "suspend", "sympathy", "thigh", "throne", "total", "unseen", "weapon", "weary" };            
            int TotalWords = words.Length;


            do
            {
                if (running == false)
                    break;
                KeySeed.Clear();
                charlength = RandomNumberGenerator.GetInt32(NrofCharsMin, NrofChars + 1);

                if (wordsUsecheck == true)
                {
                    for (x = 1; x <= charlength; x++)
                    {
                        KeySeed.Append(words[RandomNumberGenerator.GetInt32(TotalWords)]);
                        KeySeed.Append(' ');
                    }

                    if (chkSeed.Checked)
                    {
                        //Add Custon Seed to the end of the random passphrase
                        KeySeed.Append(seedText);

                    }
                    else
                    {
                        KeySeed.Remove((KeySeed.Length - 1), 1);
                    }




                }
                else
                {
                    for (x = 1; x <= charlength; x++)
                    {
                        KeySeed.Append(chars[RandomNumberGenerator.GetInt32(TotalChars)]);
                    }

                    if (chkSeed.Checked)
                    {
                        //Add Custon Seed to the end of the random passphrase
                        KeySeed.Append(seedText);

                    }
                }
 





                PrivateKey = cSHA256.ComputeHash(Encoding.UTF8.GetBytes(KeySeed.ToString()));
                byte[] ClampPrivate = Curve25519.ClampPrivateKey(PrivateKey);
                PublicKey = Curve25519.GetPublicKey(ClampPrivate);
                PublicKeyHash = cSHA256.ComputeHash(PublicKey); 

                b = new byte[] { PublicKeyHash[0], PublicKeyHash[1], PublicKeyHash[2], PublicKeyHash[3], PublicKeyHash[4], PublicKeyHash[5], PublicKeyHash[6], PublicKeyHash[7] };
                if ((b[^1] & 0x80) != 0)
                    Array.Resize<byte>(ref b, b.Length + 1);

                    var accountLong = Convert.ToUInt64(new BigInteger(b, true, false).ToString());
                    AccountID = accountLong.ToString();

                    AccountAddress = ReedSolomon.encode(accountLong);


                lock (LockObj)
                    Tested += 1;
                if (toFindPattern.IsMatch(AccountAddress))
                {
                    var validationResult = ValidateAddress(AccountID);


                    if(!validationResult.Item2)
                    {
                        if (validationResult.Item1)
                        {
                            Found(AccountAddress, KeySeed.ToString(), AccountID);
                            return;
                        }
                    }
                    else
                    {
                        Error();
                        return;
                            
                    }

                     

                }
            }
            while (true);
        }

        private void Error()
        {

            if (InvokeRequired)
            {
                DError d = new(Error);
                Invoke(d, Array.Empty<object>());
                return;
            }


            running = false;
            txtAddress.Text = "";
            txtPass.Text = "";
            txtAcct.Text = "";
            tmr.Enabled = false;
            btnStart.Text = "Start";
            btnSave.Enabled = true;
            GroupOptions.Enabled = true;
            GroupAddress.Enabled = true;
            comboBox1.Enabled = true;

            lblGenStatus.ForeColor = Color.Red;
            lblGenStatus.Text = "Match found....Unable to validate.  Check connection settings.";

        }

        private  (bool, bool) ValidateAddress(string ID)
        {
            //Use Account Numeric ID for checking.... Will work on TestNet Nodes then because of new TS- vs S


            bool returnresult = false;
            bool error = true;

            IGetAccount getAccount;

            // ... Use HttpClient.
            using (HttpClient client = new())
            {
                //client.BaseAddress = new Uri("http://216.222.169.198:8125");
                client.BaseAddress = new Uri(uriString: SRS_Node);
                client.DefaultRequestHeaders.Accept.Add(
                             new MediaTypeWithQualityHeaderValue("application/json"));
                var requesturl = "burst?requestType=getAccount&account=" + ID;


                try
               {
                    using (HttpResponseMessage response =  client.GetAsync(requesturl).Result)
                    {
                        using (HttpContent content = response.Content)    
                        {
                            getAccount = content.ReadFromJsonAsync<GetAccount>().Result;

                            HttpResponseHeaders headers = response.Headers;
                            HttpStatusCode code = response.StatusCode;

                            if (code == HttpStatusCode.OK)
                            {
                                error = false;

                                if(getAccount != null)
                                {
                                    if(getAccount.ErrorCode != 0)
                                    {
                                        returnresult = true;

                                        
                                    }
                                    else
                                    {
                                        returnresult = false;
                                        
                                    }
                                }
                                else
                                {
                                    returnresult = false;
                                    
                                }

                            }

                        }
                    }


                }
                catch (Exception)
                {
                    // need to return ex.message for display.
                    

                }

            }

            return (returnresult, error);


        }

        #region Text Field Change Events
        private void TxtFind1_TextChanged(object sender, EventArgs e)
        {
            int Index = txtFind1.SelectionStart;
            string result = txtFind1.Text;
            txtFind1.Text = SanitizeTxt(result, 4);
            txtFind1.Select(Index, 0);
            if (Index == 4)
            {
                txtFind2.Focus();
                txtFind2.Select(0, 0);
            }
        }

        private void TxtFind2_TextChanged(object sender, EventArgs e)
        {
            int Index = txtFind2.SelectionStart;
            string result = txtFind2.Text;
            txtFind2.Text = SanitizeTxt(result, 4);
            txtFind2.Select(Index, 0);
            if (Index == 4)
            {
                txtFind3.Focus();
                txtFind3.Select(0, 0);
            }
        }

        private void TxtFind3_TextChanged(object sender, EventArgs e)
        {
            int Index = txtFind3.SelectionStart;
            string result = txtFind3.Text;
            txtFind3.Text = SanitizeTxt(result, 4);
            txtFind3.Select(Index, 0);
            if (Index == 4)
            {
                txtFind4.Focus();
                txtFind4.Select(0, 0);
            }
        }

        private void TxtFind4_TextChanged(object sender, EventArgs e)
        {
            int Index = txtFind4.SelectionStart;
            string result = txtFind4.Text;
            txtFind4.Text = SanitizeTxt(result, 5);
            txtFind4.Select(Index, 0);
        }
        #endregion

        #region Text Field KeyDown Events

        private void TxtFind4_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFind4.SelectionStart == 0)
            {
                if (e.KeyCode == Keys.Back)
                    txtFind3.Focus();
            }
        }

        private void TxtFind3_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFind3.SelectionStart == 0)
            {
                if (e.KeyCode == Keys.Back)
                    txtFind2.Focus();
            }
        }

        private void TxtFind2_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtFind2.SelectionStart == 0)
            {
                if (e.KeyCode == Keys.Back)
                    txtFind1.Focus();
            }
        }


        #endregion

        private static string SanitizeTxt(string result, int allowedLength)
        {
            while (result.Length < allowedLength)
                result += "@";
            char[] txt = result.ToUpper().ToCharArray();
            var chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789@";
            var charsfive = "ABCDEFGH23456789@";
            result = "";
            for (var t = 0; t <= (allowedLength - 1); t++)
            {
                if (t == 0 & allowedLength == 5)
                {
                    if (!charsfive.Contains(txt[t]))
                        txt[t] = Convert.ToChar("@");
                }
                if (!chars.Contains(txt[t]))
                    txt[t] = Convert.ToChar("@");
                result += txt[t];
            }
            return result;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
      
            lock (LockObj)
            {
                lblTested.Text = Convert.ToString(Tested);
                    counter += 1;
                if (counter == 10)
                {
                    
                    lblTesting.Text = Convert.ToString(Tested - lastval) + " keys/sec";
                    lastval = Convert.ToInt64(Tested);
                    counter = 0;
                }
            }
        }


        private void NrPassMin_ValueChanged(object sender, EventArgs e)
        {
            if (nrPassMin.Value >= nrPass.Value)
                nrPass.Value = nrPassMin.Value;
        }
        private void NrPass_ValueChanged(object sender, EventArgs e)
        {
            if (nrPass.Value <= nrPassMin.Value)
                nrPassMin.Value = nrPass.Value;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                Filter = "Text Files (*.txt)|*.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string Buffer = "Address:" + "\r\n";
                    Buffer += txtAddress.Text + "\r\n" + "\r\n";
                    Buffer += "Account Numeric:" + "\r\n";
                    Buffer += txtAcct.Text + "\r\n" + "\r\n"; ;
                    Buffer += "Passphrase:" + "\r\n";
                    Buffer += txtPass.Text;
                    File.WriteAllText(sfd.FileName, Buffer);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                MessageBox.Show("Account information is saved", "File Saved", MessageBoxButtons.OK);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            running = false;
            LockObj = new object();

            nrThreads.Maximum = Environment.ProcessorCount;
            
            nrThreads.Minimum = 1;
            comboBox1.SelectedIndex = 0;
            SRS_Node = comboBox1.SelectedItem.ToString();
            lblGenStatus.Text = "";

            GroupAll.Enabled = false;

            if(nrThreads.Maximum <= 1)
                {
                    nrThreads.Value = 1;
                }
            else
                {
                    nrThreads.Value = nrThreads.Maximum/2;
                }

        }

        private void Found(string Address, string Pass, string ID)
        {
            if (InvokeRequired)
            {
                DFound d = new(Found);
                Invoke(d, new object[] { Address, Pass, ID });
                return;
            }

          
                running = false;
                txtAddress.Text = "S-" + Address;
                txtPass.Text = Pass;
                txtAcct.Text = ID;
                tmr.Enabled = false;
                btnStart.Text = "Start";
                btnSave.Enabled = true;
                GroupOptions.Enabled = true;
                GroupAddress.Enabled = true;
                 comboBox1.Enabled = true;

                lblGenStatus.ForeColor = Color.Green;
                lblGenStatus.Text = "Congrats!  Matching Address Found!";


        }

        private void UseWords_CheckedChanged(object sender, EventArgs e)
        {
            if (UseWords.Checked)
            {
                nrPass.Minimum = 12;
                nrPassMin.Minimum = 12;
                nrPass.Maximum = 36;
                nrPassMin.Maximum = 36;
                nrPass.Value = 12;
                nrPassMin.Value = 12;
            }
            else
            {
                nrPass.Minimum = 64;
                nrPassMin.Minimum = 64;
                nrPass.Maximum = 1000;
                nrPassMin.Maximum = 1000;
            }

        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            GroupAll.Enabled = false;
            txtAddress.Clear();
            txtPass.Clear();
            txtAcct.Clear();
            lblGenStatus.Text = "";
            lblNodeStatus.ForeColor = Color.Orange;
            lblNodeStatus.Text = "VALIDATING.........Please Wait!";

            SRS_Node = comboBox1.SelectedItem.ToString();
            (bool, string) result = ValidateSRSNode();

            if (result.Item1)
            {
                GroupAll.Enabled = true;
                lblNodeStatus.Text = result.Item2;
                lblNodeStatus.ForeColor = Color.Green;
            }
            else
            {
                GroupAll.Enabled = false;
                lblNodeStatus.Text = result.Item2;
                lblNodeStatus.ForeColor = Color.Red;
            }
        }

        private (bool, string) ValidateSRSNode()
        {

            bool returnresult = false;
            string message = "";

            IGetBlockchainStatus getBlockchainStatus;


            // ... Use HttpClient.
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri(uriString: SRS_Node);
                client.DefaultRequestHeaders.Accept.Add(
                             new MediaTypeWithQualityHeaderValue("application/json"));
                var requesturl = "burst?requestType=getBlockchainStatus";

                try
                {
                    using (HttpResponseMessage response = client.GetAsync(requesturl).Result)
                    {
                        using (HttpContent content = response.Content)
                        {
                           // string result = content.ReadAsStringAsync().Result;

                            getBlockchainStatus = content.ReadFromJsonAsync<GetBlockchainStatus>().Result;

                            HttpResponseHeaders headers = response.Headers;
                            HttpStatusCode code = response.StatusCode;

                            if (code == HttpStatusCode.OK)
                            {

                                if(getBlockchainStatus != null)
                                    {
                                  
                                        var difference = getBlockchainStatus.Time - getBlockchainStatus.LastBlockTimestamp;

                                            if(difference > (8*60))
                                            {
                                                returnresult = false;
                                                message = "Node not up to date.  Hours behind: " + TimeSpan.FromSeconds(difference).TotalHours.ToString("N2");
                                            }
                                            else
                                            {
                                                returnresult = true;
                                                message = "SRS Node is Valid and Up to Date!";
                                            }
                                            

                                }
                                else
                                {
                                    returnresult = false;
                                    message = "SRS Node Query failed";
                                }

                            }
                            //http error results in no valid
                            else
                            {
                                returnresult = false;
                                message = "Check SRS Server is running and ports open";
                            }


                        }
                    }


                }
                catch (Exception)
                {
                    returnresult = false;
                    message = "Unable to make a connection to server";

                }

            }

            return (returnresult, message);


        }


    }
}
