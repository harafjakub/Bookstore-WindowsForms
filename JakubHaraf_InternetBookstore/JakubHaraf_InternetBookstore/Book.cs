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
    class Book : Product
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // FIELDS OF CLASS

        private int pages; // number of pages in the book
        private int[] dimension; // book dimension (length x width x height)
        private string format; // book format, e.g. soft cover, hard cover, e-book, audio-book
        private string originalLanguage; // book language in the original
        private string releaseLanguage; // the language of this particular copy of the book
        private string isbn; // international standardized book number, unique 13-digit book identifier


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // CLASS METHODS

        // no argument constructor that calls the base class constructor
        public Book() : base()
        {
            this.pages = 0;
            this.dimension = new int[3] { 170, 242, 48 };
            this.format = "Soft cover";
            this.originalLanguage = "English";
            this.releaseLanguage = "Polish";
            this.isbn = "0000000000000";
        }

        // argument constructor that calls the base class constructor
        public Book(string title, string author, string publisher, string[] genre, string series, DateTime releaseDate, DateTime addedDate, float price, float rating,
                    int soldQuantity, bool available, string descripiton, Bitmap cover, int pages, int[] dimension, string format, string originalLanguage,
                    string releaseLanguage, string isbn)
                    : base(title, author, publisher, genre, series, releaseDate, addedDate, price, rating, soldQuantity, available, descripiton, cover)
        {
            this.pages = pages;
            this.dimension = dimension;
            this.format = format;
            this.originalLanguage = originalLanguage;
            this.releaseLanguage = releaseLanguage;
            this.isbn = isbn;
            this.isbn = isbn;
        }

        // copy constructor that calls the base class constructor
        public Book(Book b) : base(b)
        {
            this.pages = b.pages;
            this.dimension = b.dimension;
            this.format = b.format;
            this.originalLanguage = b.originalLanguage;
            this.releaseLanguage = b.releaseLanguage;
            this.isbn = b.isbn;
        }

        // virtual method outputting information about the passed object in Listbox
        public override void Write(ListBox l1)
        {
            l1.Items.Add("Product ID: \t\t" + this.id);
            l1.Items.Add("Title: \t\t\t" + this.title);
            l1.Items.Add("Author: \t\t\t" + this.author);
            l1.Items.Add("Publisher: \t\t" + this.publisher);
            l1.Items.Add("Genre: \t\t\t" + WriteStringArray(this.genre, ", "));
            l1.Items.Add("Series: \t\t\t" + this.series);
            l1.Items.Add("Release date: \t\t" + this.releaseDate.Year + "-" + this.releaseDate.Month + "-" + this.releaseDate.Day + " (" + StringNumOfYears() + ")");
            l1.Items.Add("Added date: \t\t" + this.addedDate.Year + "-" + this.addedDate.Month + "-" + this.addedDate.Day);
            l1.Items.Add("Price: \t\t\t" + SaleOfNotPopular(40));
            l1.Items.Add("Rating: \t\t\t" + StarsRating());
            l1.Items.Add("Number of titles sold: \t" + this.soldQuantity);
            l1.Items.Add("Available: \t\t" + this.available);
            l1.Items.Add("Description: \t\t" + this.descripiton);
            l1.Items.Add("Pages: \t\t\t" + this.pages);
            l1.Items.Add("Dimension [mm]: \t\t" + WriteStringArray(Array.ConvertAll(this.dimension, x => x.ToString()), " x "));
            l1.Items.Add("Format: \t\t\t" + this.format);
            l1.Items.Add("Original language: \t\t" + this.originalLanguage);
            l1.Items.Add("Release language: \t\t" + this.releaseLanguage);
            l1.Items.Add("ISBN: \t\t\t" + this.isbn);
            l1.Items.Add("Average read time: \t\t" + AverageTime());
            l1.Items.Add("");
        }

        // virtual overloaded method outputting information about the passed object in Listbox and photo of the object in Picturebox
        public override void Write(ListBox l1, PictureBox p1)
        {
            l1.Items.Add("Product ID: \t\t" + this.id);
            l1.Items.Add("Title: \t\t\t" + this.title);
            l1.Items.Add("Author: \t\t\t" + this.author);
            l1.Items.Add("Publisher: \t\t" + this.publisher);
            l1.Items.Add("Genre: \t\t\t" + WriteStringArray(this.genre, ", "));
            l1.Items.Add("Series: \t\t\t" + this.series);
            l1.Items.Add("Release date: \t\t" + this.releaseDate.Year + "-" + this.releaseDate.Month + "-" + this.releaseDate.Day + " (" + StringNumOfYears() + ")");
            l1.Items.Add("Added date: \t\t" + this.addedDate.Year + "-" + this.addedDate.Month + "-" + this.addedDate.Day);
            l1.Items.Add("Price: \t\t\t" + SaleOfNotPopular(40));
            l1.Items.Add("Rating: \t\t\t" + StarsRating());
            l1.Items.Add("Number of titles sold: \t" + this.soldQuantity);
            l1.Items.Add("Available: \t\t" + this.available);
            l1.Items.Add("Description: \t\t" + this.descripiton);
            l1.Items.Add("Pages: \t\t\t" + this.pages);
            l1.Items.Add("Dimension [mm]: \t\t" + WriteStringArray(Array.ConvertAll(this.dimension, x => x.ToString()), " x "));
            l1.Items.Add("Format: \t\t\t" + this.format);
            l1.Items.Add("Original language: \t\t" + this.originalLanguage);
            l1.Items.Add("Release language: \t\t" + this.releaseLanguage);
            l1.Items.Add("ISBN: \t\t\t" + this.isbn);
            l1.Items.Add("Average read time: \t\t" + AverageTime());
            l1.Items.Add("");
            p1.Image = this.cover;
        }

        // method that sells off by a percentage passed as an argument for books that do not sell well (number of units sold < 500) and have been on sale for more than a year
        private string SaleOfNotPopular(int percent)
        {
            if (soldQuantity < 500 && NumOfYears() > 0)
            {
                double temp = (100.0 - (double)percent) / 100.0;
                return Math.Round(this.price * temp, 2) + " zł (-" + percent + "%)";
            }
            else
            {
                return this.price + " zł";
            }
        }

        // method calculates the average time to read a book based on the number of pages, assuming that the reading time per page is 2 minutes
        private string AverageTime()
        {
            int hours, minutes;
            minutes = this.pages / 2;
            hours = minutes / 60;
            minutes -= hours * 60;
            if (hours == 0)
            {
                return minutes + "min";
            }
            else if (minutes == 0)
            {
                return hours + "h ";
            }
            else
            {
                return hours + "h " + minutes + "min";
            }
        }

        // overloaded operator ==, checking if books are of the same author series
        public static bool operator ==(Book b1, Book b2)
        {
            if (b1.series == b2.series && b1.author == b2.author)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // overloaded operator !=, checking if books are of the same author series
        public static bool operator !=(Book b1, Book b2)
        {
            if (b1.series == b2.series && b1.author == b2.author)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // overloaded operator +, creates a set of books of the same author series
        public static Book operator +(Book b1, Book b2)
        {
            Book b3 = new Book();
            b3.title = b1.title + " + " + b2.title;
            b3.author = b1.author;
            b3.publisher = b1.publisher;
            b3.genre = b1.genre;
            b3.series = b1.series;
            b3.releaseDate = DateTime.Now;
            b3.addedDate = DateTime.Now;
            b3.price = b1.price + b2.price;
            b3.rating = (b1.rating + b2.rating) / 2;
            b3.soldQuantity = 0;
            b3.descripiton = "A set of " + b1.author + " books.";
            b3.pages = b1.pages + b2.pages;
            if (b1.dimension[0] > b2.dimension[0])
            {
                b3.dimension[0] = b1.dimension[0];
            }
            else
            {
                b3.dimension[0] = b2.dimension[0];
            }
            if (b1.dimension[2] > b2.dimension[2])
            {
                b3.dimension[2] = b1.dimension[2];
            }
            else
            {
                b3.dimension[2] = b2.dimension[2];
            }
            b3.dimension[1] = b1.dimension[1] + b2.dimension[1];
            b3.format = b1.format;
            b3.originalLanguage = b1.originalLanguage;
            b3.releaseLanguage = b1.releaseLanguage;
            b3.isbn = b1.isbn;
            b3.available = true;
            b3.cover = new Bitmap(Properties.Resources.nophoto);
            return b3;
        }

        /*
        public static Book operator +(Book b1, float rating)
        {
            b1.soldQuantity++;
            b1.rating = ((b1.rating * (b1.soldQuantity - 1)) + rating) / b1.soldQuantity;
            return b1;
        }
        */

        // method splitting the text given in the textbox into array elements, where the elements are separated by ","
        private string[] TextBoxToArray(String text)
        {
            string[] elements = text.Split(',');
            return elements;
        }

        // method saving book cover to .txt file in Base64 format
        private void SaveBmp(StreamWriter sw)
        {
    
            using (MemoryStream ms = new MemoryStream())
            {
                new Bitmap(cover).Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        // method loading book cover from .txt file in Base64 format
        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }

        }

        // virtual method that saves the field values and cover picture ​​of the Book class object to a text file
        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("== book ==");
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
            sw.WriteLine(this.pages);
            sw.WriteLine(WriteStringArray(Array.ConvertAll(this.dimension, x => x.ToString()), ","));
            sw.WriteLine(this.format);
            sw.WriteLine(this.originalLanguage);
            sw.WriteLine(this.releaseLanguage);
            sw.WriteLine(this.isbn);
            SaveBmp(sw);
        }

        // virtual method that reads the field values and cover picture ​​of the Book class object from a text file
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
            this.pages = Convert.ToInt32(sr.ReadLine());
            this.dimension = Array.ConvertAll(TextBoxToArray(sr.ReadLine()), int.Parse);
            this.format = sr.ReadLine();
            this.originalLanguage = sr.ReadLine();
            this.releaseLanguage = sr.ReadLine();
            this.isbn = sr.ReadLine();
            this.cover = LoadBmp(sr);
        }
    }
}
