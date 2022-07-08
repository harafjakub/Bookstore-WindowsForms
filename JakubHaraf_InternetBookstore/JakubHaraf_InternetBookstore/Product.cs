using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace JakubHaraf_InternetBookstore
{
    // Definition of the ABSTRACT class (base) Product
    public abstract class Product: IComparable<Product>
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // FIELDS OF CLASS

        protected int id; // identifier, unique for each object and having auto increment
        protected string title; // product name
        protected string author; // product author
        protected string publisher; // product publisher
        protected string[] genre; // genre e.g. sci-fi, horror
        protected string series; // series of the product
        protected DateTime releaseDate; // date of product release to the world market
        protected DateTime addedDate; // date when the product was added to the bookstore
        protected float price; // the base price of the product in zł
        protected float rating; // rating of the product on a scale from 1 to 10
        protected int soldQuantity; // number of titles sold
        protected bool available; // is the product available, someone has not bought/booked it
        protected string descripiton; // short description of the product
        protected Bitmap cover; // product cover image
        static protected int productCounter = 0; // static variable that holds the quantity of all products, also needed for automatic id assignment


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        // CLASS METHODS

        // no argument constructor, initializes the fields with default values
        public Product() 
        {
            productCounter++;
            this.id = productCounter;
            this.title = "-";
            this.author = "-";
            this.publisher = "-";
            this.genre = new string[] { "-" };
            this.series = "-";
            this.releaseDate = DateTime.Now;
            this.addedDate = DateTime.Now;
            this.price = 0;
            this.rating = 5;
            this.soldQuantity = 0;
            this.available = false;
            this.descripiton = "A short description of the product";
            this.cover = new Bitmap(Properties.Resources.nophoto);
        }

        // argument constructor, initializes the fields with the values of the arguments passed
        public Product(string title, string author, string publisher, string[] genre, string series, DateTime releaseDate, DateTime addedDate, float price, float rating, 
                       int soldQuantity, bool available, string descripiton, Bitmap cover) 
        {
            productCounter++;
            this.id = productCounter;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.genre = genre;
            this.series = series;
            this.releaseDate = releaseDate;
            this.addedDate = addedDate;
            this.price = price;
            this.rating = rating;
            this.soldQuantity = soldQuantity;
            this.available = available;
            this.descripiton = descripiton;
            this.cover = cover;
        }

        // copy constructor, initializes the field with the values copied from the argument - of the Product class object, only id is diffrent (i.e. each object will have unique id)
        public Product(Product p) 
        {
            productCounter++;
            this.id = productCounter;
            this.title = p.title;
            this.author = p.author;
            this.publisher = p.publisher;
            this.genre = p.genre;
            this.series = p.series;
            this.releaseDate = p.releaseDate;
            this.addedDate = p.addedDate;
            this.price = p.price;
            this.rating = p.rating;
            this.soldQuantity = p.soldQuantity;
            this.available = p.available;
            this.descripiton = p.descripiton;
            this.cover = p.cover;
        }

        // destructor
        ~Product() 
        {
            //MessageBox.Show("Destructor was called");
        }

        // virtual method outputting information about the passed object in Listbox
        virtual public void Write(ListBox l1) 
        {
            l1.Items.Add("Product ID: \t\t" + this.id);
            l1.Items.Add("Title: \t\t\t" + this.title);
            l1.Items.Add("Author: \t\t\t" + this.author);
            l1.Items.Add("Publisher: \t\t" + this.publisher);
            l1.Items.Add("Genre: \t\t\t" + WriteStringArray(this.genre, ", "));
            l1.Items.Add("Series: \t\t\t" + this.series);
            l1.Items.Add("Release date: \t\t" + this.releaseDate.Year + "-" + this.releaseDate.Month + "-" + this.releaseDate.Day + " (" + StringNumOfYears() + ")");
            l1.Items.Add("Added date: \t\t" + this.addedDate.Year + "-" + this.addedDate.Month + "-" + this.addedDate.Day);
            l1.Items.Add("Price: \t\t\t" + this.price + " zł");
            l1.Items.Add("Rating: \t\t\t" + StarsRating());
            l1.Items.Add("Number of titles sold: \t" + this.soldQuantity);
            l1.Items.Add("Available: \t\t" + this.available);
            l1.Items.Add("Description: \t\t" + this.descripiton);
        }

        // overloaded virtual method outputting information about the passed object in Listbox and photo of the object in Picturebox
        virtual public void Write(ListBox l1, PictureBox p1)
        {
            l1.Items.Add("Product ID: \t\t" + this.id);
            l1.Items.Add("Title: \t\t\t" + this.title);
            l1.Items.Add("Author: \t\t\t" + this.author);
            l1.Items.Add("Publisher: \t\t" + this.publisher);
            l1.Items.Add("Genre: \t\t\t" + WriteStringArray(this.genre, ", "));
            l1.Items.Add("Series: \t\t\t" + this.series);
            l1.Items.Add("Release date: \t\t" + this.releaseDate.Year + "-" + this.releaseDate.Month + "-" + this.releaseDate.Day + " (" + StringNumOfYears() + ")");
            l1.Items.Add("Added date: \t\t" + this.addedDate.Year + "-" + this.addedDate.Month + "-" + this.addedDate.Day);
            l1.Items.Add("Price: \t\t\t" + this.price + " zł");
            l1.Items.Add("Rating: \t\t\t" + StarsRating());
            l1.Items.Add("Number of titles sold: \t" + this.soldQuantity);
            l1.Items.Add("Available: \t\t" + this.available);
            l1.Items.Add("Description: \t\t" + this.descripiton);
            p1.Image = this.cover;
        }

        /*
        // method for display the product cover in the passed PictureBox
        public void ShowCover(PictureBox p1)
        {
            p1.Image = this.cover;
        }
        */

        // method that counts approximately how old a given product is based on the date of release
        protected int NumOfYears() 
        {
            if(DateTime.Now.Year == this.releaseDate.Year && (DateTime.Now.Month > this.releaseDate.Month || DateTime.Now.Month == this.releaseDate.Month && DateTime.Now.Day >= this.releaseDate.Day))
            {
                return 0;
            }
            else if(DateTime.Now.Month > this.releaseDate.Month || (DateTime.Now.Month == this.releaseDate.Month && DateTime.Now.Day >= this.releaseDate.Day))
            {
                return DateTime.Now.Year - this.releaseDate.Year;
            }
            else
            {
                return DateTime.Now.Year - this.releaseDate.Year-1 ;
            }
        }

        // method returning how old the product is in years, if 0 display inforamtion about recent premiere, if < 0 information about future premiere 
        protected string StringNumOfYears()
        {
            int temp = NumOfYears();
            if (temp == 0)
            {
                return "Recent premiere!";
            }
            else if (temp < 0)
            {
                return "Future premiere!";
            }
            else if (temp == 1)
            {
                return temp + " year";
            }
            else
            {
                return temp + " years";
            }
        }
        
        // method for converting float ratings to stars, rounding the rating to int
        protected string StarsRating() 
        {
            string stars = "";
            int temp = (int)Math.Round(this.rating);
            for (int i = 0; i < temp; i++)
            {
                stars += "\u2605";
            }
            for (int i = temp; i < 10; i++)
            {
                stars += "\u2606";
            }
            return stars;
        }

        // method that places all the elements of the passed array t in a string variable, separating them with the given separator
        protected string WriteStringArray(string[] t, string separator)
        {
            string text = "";
            int i;
            for (i = 0; i < t.Length - 1; i++)
            {
                text += t[i] + separator;
            }
            text += t[i];
            return text;
        }

        // method that reseting productCounter to 0
        public static void ResetProductCounter()
        {
            productCounter = 0;
        }

        // method that returns product id
        public int GetProductId()
        {
            return this.id;
        }

        // virtual method that writes field values and cover picture ​​to a text file, defined in derived classes
        public virtual void WriteToFile(StreamWriter sw)
        {
        }

        // virtual method that reads field values and cover picture ​​from a text file, defined in derived classes
        public virtual void ReadFromFile(StreamReader sr)
        {
        }

        // the method counts the average price of the products based on productList
        public static decimal AvgPrice()
        {
            decimal avgPrice = 0;
            int quantity = 0;
            for (int i = 0; i <= FormMenu.productList.Count - 1; i++)
            {
                avgPrice += (decimal)FormMenu.productList[i].price;
                quantity++;
            }
            avgPrice /= quantity;
            return Math.Round((decimal)avgPrice, 2); ;
        }

        // the method counts the average rating of the products based on productList
        public static decimal AvgRating()
        {
            decimal avgRating = 0;
            int quantity = 0;
            for (int i = 0; i <= FormMenu.productList.Count - 1; i++)
            {
                avgRating += (decimal)FormMenu.productList[i].rating;
                quantity++;
            }
            avgRating /= quantity;
            return Math.Round((decimal)avgRating, 1); ;
        }

        // the method counts the average amount of products sold based on productList
        public static decimal AvgNumOfProducts()
        {
            decimal avgNumOfProducts = 0;
            int quantity = 0;
            for (int i = 0; i <= FormMenu.productList.Count - 1; i++)
            {
                avgNumOfProducts += (decimal)FormMenu.productList[i].soldQuantity;
                quantity++;
            }
            avgNumOfProducts /= quantity;
            return Math.Round((decimal)avgNumOfProducts, 0); ;
        }

        // the method counts the amount of generated capital of all products based on productList
        public static decimal GenCapital()
        {
            decimal genCapital = 0;
            for (int i = 0; i <= FormMenu.productList.Count - 1; i++)
            {
                genCapital += (decimal)FormMenu.productList[i].soldQuantity * (decimal)FormMenu.productList[i].price;
            }
            return Math.Round((decimal)genCapital, 2);
        }

        // method displaying the titles and id of all products on the productList in the list box, including whether it is a book or a game
        public static void DisplayShortcutOfProducts(ListBox l1)
        {
            int i = 0;
            foreach (Product p in FormMenu.productList) // displays books
            {
                if (FormMenu.productList[i] is Book)
                {
                    l1.Items.Add("Book (id: " + FormMenu.productList[i].GetProductId() + ") - " + FormMenu.productList[i].title);
                }
                i++;

            }

            i = 0;
            foreach (Product p in FormMenu.productList) // displays games
            {
                if (FormMenu.productList[i] is Game)
                {
                    l1.Items.Add("Game (id: " + FormMenu.productList[i].GetProductId() + ") - " + FormMenu.productList[i].title);
                }
                i++;
            }
        }

        // overloaded method from the IComparable interface
        public int CompareTo(Product product)
        {
            if (product == null)
                return 1;
            // sort by author
            if (String.Compare(this.author, product.author) == 1)
                return 1;
            else if (String.Compare(this.author, product.author) == -1)
                return -1;
            else
            {
                // objects with the same author will be sorted by price
                if (this.price > product.price)
                    return 1;
                else if (this.price < product.price)
                    return -1;
                else
                {
                    // objects with the same author and price will be sorted by title
                    if (String.Compare(this.title, product.title) == 1)
                        return 1;
                    else if (String.Compare(this.title, product.title) == -1)
                        return -1;
                    return 0;
                }
            }
        }

        // method that returns an array of strings in which there are fields of the object converted to strings
        public string[] FieldsToStringArray()
        {
            var t1 = new string[]
            {
                Convert.ToString(this.id),
                this.title,
                this.author,
                this.publisher,
                WriteStringArray(this.genre, ", "),
                this.series,
                this.releaseDate.ToString("dd/MM/yyyy"),
                this.addedDate.ToString("dd/MM/yyyy"),
                Convert.ToString(this.price),
                this.StarsRating(),
                Convert.ToString(this.soldQuantity),
                Convert.ToString(this.available)
            };
            return t1;
        }

        // method that checks if the title of the object contains the text specified in the argument and returns a true or false
        public bool WhereTitle(string phrase)
        {
            return this.title.Contains(phrase);
        }

        // method that checks if the price of an object is in the range passed as 2 arguments that return true or false
        public bool WherePrice(float from, float to)
        {
            return (this.price >= from && this.price <= to);
        }
    }
}
