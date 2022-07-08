using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubHaraf_InternetBookstore
{
    // class derived from product class
    class Game : Product
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // FIELDS OF CLASS

        private string[] dubbingLanguage; // language of dubbing available in the game
        private string[] subtitleLanguage; // language of subtitles available in the game
        private int pegi; // Pan European Game Information - minimum recommended age to play
        private string platform; // the platform on which this copy of the game is
        private bool singleplayer; // does the game have a singleplayer mode
        private bool multiplayer; // does the game have a multiplayer mode
        private string key; // digital key to access the game - auto generated


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // CLASS METHODS

        // no argument constructor that calls the base class constructor
        public Game() : base() 
        {
            this.dubbingLanguage = new string[] {"English"};
            this.subtitleLanguage = new string[] {"English","Polish"};
            this.pegi = 18;
            this.platform = "PC";
            this.singleplayer = true;
            this.multiplayer = false;
            this.key = GenerateKey();
        }

        // argument constructor that calls the base class constructor
        public Game(string title, string author, string publisher, string[] genre, string series, DateTime releaseDate, DateTime addedDate, float price, float rating, 
                    int soldQuantity, bool available, string descripiton, Bitmap cover, string[] dubbingLanguage, string[] subtitleLanguage, int pegi, string platform, 
                    bool singleplayer, bool multiplayer) 
                    : base(title, author, publisher, genre, series, releaseDate, addedDate, price, rating, soldQuantity, available, descripiton, cover)          
        {
            this.dubbingLanguage = dubbingLanguage;
            this.subtitleLanguage = subtitleLanguage;
            this.pegi = pegi;
            this.platform = platform;
            this.singleplayer = singleplayer;
            this.multiplayer = multiplayer;
            this.key = GenerateKey();
        }

        // copy constructor that calls the base class constructor
        public Game(Game g) : base(g) 
        {
            this.dubbingLanguage = g.dubbingLanguage;
            this.subtitleLanguage = g.subtitleLanguage;
            this.pegi = g.pegi;
            this.platform = g.platform;
            this.singleplayer = g.singleplayer;
            this.multiplayer = g.multiplayer;
            this.key = GenerateKey();
        }

        // virtual method outputting information about the passed object in Listbox
        public override void Write(ListBox l1)
        {
            base.Write(l1);
            l1.Items.Add("Dubbing Language: \t" + WriteStringArray(this.dubbingLanguage, ", "));
            l1.Items.Add("Subtitle Language: \t\t" + WriteStringArray(this.subtitleLanguage, ", "));
            l1.Items.Add("PEGI: \t\t\t" + this.pegi + " (Buyer's minimum date of birth: " + MinBuyersDateBirth() + ")");
            l1.Items.Add("Platform: \t\t\t" + this.platform);
            l1.Items.Add("Multi-player mode: \t\t" + this.multiplayer);
            l1.Items.Add("Single-player mode: \t" + this.singleplayer);
            l1.Items.Add("Key: \t\t\t" + this.key);
            l1.Items.Add("");
        }

        // virtual overloaded method outputting information about the passed object in Listbox and photo of the object in Picturebox
        public override void Write(ListBox l1, PictureBox p1) 
        {
            base.Write(l1,p1);
            l1.Items.Add("Dubbing Language: \t" + WriteStringArray(this.dubbingLanguage, ", "));
            l1.Items.Add("Subtitle Language: \t\t" + WriteStringArray(this.subtitleLanguage, ", "));
            l1.Items.Add("PEGI: \t\t\t" + this.pegi + " (Buyer's minimum date of birth: " + MinBuyersDateBirth() + ")");
            l1.Items.Add("Platform: \t\t\t" + this.platform);
            l1.Items.Add("Multi-player mode: \t\t" + this.multiplayer);
            l1.Items.Add("Single-player mode: \t" + this.singleplayer);
            l1.Items.Add("Key: \t\t\t" + this.key);
            l1.Items.Add("");
        }

        // method for calculating the minimum required date of birth of the buyer
        private string MinBuyersDateBirth()
        {
            int birthYear = DateTime.Now.Year - this.pegi;
            string birthDate = birthYear + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            return birthDate;
        }

        // method that generates a random key in format "AAAAA-BBBBB-CCCCC-DDDDD-EEEEE" composed of numbers 1-9 and the letters A-Z for the key field
        private string GenerateKey()
        {
            string key = "AAAAA-BBBBB-CCCCC-DDDDD-EEEEE";
            char[] keyAsChars = key.ToCharArray();
            Random random = new Random();
            for(int i=0; i<keyAsChars.Length; i++)
            {
                if(random.Next(0, 2) == 0)
                {
                    keyAsChars[i] = (char)random.Next(48, 58); // 0-9
                }
                else
                {
                    keyAsChars[i] = (char)random.Next(65, 91); // A-Z
                }
            }
            for(int i=5; i<keyAsChars.Length; i+=6)
            {
                keyAsChars[i] = '-';
            }
            key = new string(keyAsChars);
            return key;
        }

        // method splitting the text given in the textbox into array elements, where the elements are separated by ","
        private string[] TextBoxToArray(String text)
        {
            string[] elements = text.Split(',');
            return elements;
        }

        // method saving game cover to .txt file in Base64 format
        private void SaveBmp(StreamWriter sw)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                new Bitmap(cover).Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));

            }
        }

        // method loading game cover from .txt file in Base64 format
        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }

        // virtual method that saves the field values and cover picture ​​of the Game class object to a text file
        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("== game ==");
            sw.WriteLine(this.title);
            sw.WriteLine(this.author);
            sw.WriteLine(this.publisher);
            sw.WriteLine(WriteStringArray(this.genre, ","));
            sw.WriteLine(this.series);
            sw.WriteLine(this.releaseDate.Year + "," + this.releaseDate.Month + "," + this.releaseDate.Day);
            sw.WriteLine(this.addedDate.Year + "," + this.addedDate.Month + "," + this.addedDate.Day);
            sw.WriteLine(this.price);
            sw.WriteLine(this.rating);
            sw.WriteLine(this.soldQuantity);
            sw.WriteLine(this.available);
            sw.WriteLine(this.descripiton);
            sw.WriteLine(WriteStringArray(this.dubbingLanguage, ","));
            sw.WriteLine(WriteStringArray(this.subtitleLanguage, ","));
            sw.WriteLine(this.pegi);
            sw.WriteLine(this.platform);
            sw.WriteLine(this.multiplayer);
            sw.WriteLine(this.singleplayer);
            sw.WriteLine(this.key);
            SaveBmp(sw);
        }

        // virtual method that reads the field values and cover picture ​​of the Game class object from a text file
        public override void ReadFromFile(StreamReader sr)
        {
            this.title = sr.ReadLine();
            this.author = sr.ReadLine();
            this.publisher = sr.ReadLine();
            this.genre = TextBoxToArray(sr.ReadLine());
            this.series = sr.ReadLine();
            this.releaseDate = Convert.ToDateTime(sr.ReadLine());            this.addedDate = Convert.ToDateTime(sr.ReadLine());            this.price = float.Parse(sr.ReadLine());
            this.rating = float.Parse(sr.ReadLine());
            this.soldQuantity = Convert.ToInt32(sr.ReadLine());
            this.available = Convert.ToBoolean(sr.ReadLine());
            this.descripiton = sr.ReadLine();
            this.dubbingLanguage = TextBoxToArray(sr.ReadLine());
            this.subtitleLanguage = TextBoxToArray(sr.ReadLine());
            this.pegi = Convert.ToInt32(sr.ReadLine());
            this.platform = sr.ReadLine();
            this.multiplayer = Convert.ToBoolean(sr.ReadLine());
            this.singleplayer = Convert.ToBoolean(sr.ReadLine());
            this.key = sr.ReadLine();
            this.cover = LoadBmp(sr);
        }
    }
}
