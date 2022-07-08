using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubHaraf_InternetBookstore
{
    public partial class FormMenu : Form
    {
        FormBook formBook = new FormBook(); // form object for adding new books
        FormGame formGame = new FormGame(); // form object for adding new games
        FormBrowse formBrowse = new FormBrowse(); // form for detailed viewing of objects on the list and their deleting
        FormOperator formOperator = new FormOperator(); // form to display the overload of operator functions
        FormStatistics formStatistics = new FormStatistics(); // form for displaying bookstore statistics
        FormDisplay formDisplay = new FormDisplay(); // form for displaying the list of products and its sorting and detailed search
        FormImport formImport = new FormImport(); // from to display the imported list
        public static List<Product> productList = new List<Product>(); // list intended for derived class objects - book and game
        public static List<Product> bookList = new List<Product>(); // list intended for derived class objects - book
        public static List<Product> gameList = new List<Product>(); // list intended for derived class objects - game
        public static List<Product> tempList = new List<Product>(); // list that is used to store the list selected by the currently set filters

        // constructor of the FormMenu class
        public FormMenu()
        {
            InitializeComponent();
        }

        // button after clicking which method will show the previously created FormBook class object
        private void buttonBook_Click(object sender, EventArgs e)
        {
            formBook.ShowDialog();
        }

        // button after clicking which method will show the previously created FormGame class object
        private void buttonGame_Click(object sender, EventArgs e)
        {
            formGame.ShowDialog();
        }

        // button after clicking which method will show the previously created FormOperator class object
        private void buttonOperator_Click(object sender, EventArgs e)
        {
            formOperator.ShowDialog();
        }

        // button after clicking which method will show the previously created FormStatistics class object
        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            formStatistics.ShowDialog();
        }

        // button after clicking which method will show the previously created formBrowse class object
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            formBrowse.ShowDialog();
        }

        // button after clicking which method will show the previously created formDisplay class object
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            formDisplay.ShowDialog();
        }

        // button on which you click which will display a dialog box in which you should select a text file for saving the data. Then it saves the fields of all objects on the productList to the selected file
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog(); // dialog box for selecting the file to be saved
            sfd.Filter = "Text file|*.txt";
            sfd.Title = "Enter a file name for saving the data";
            sfd.ShowDialog();

            if (sfd.FileName != "")
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    int i = 0;
                    foreach (Product p in FormMenu.productList) // for each object in the list, call the appropriate version of the virtual WriteToFile method 
                    {
                        FormMenu.productList[i].WriteToFile(sw);
                        i++;
                    }
                    sw.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Failed to save the data - IOException.");
                }
            }
            else
            {
                MessageBox.Show("Failed to save the data.");
            }
        }

        // button after clicking which displays a dialog box in which the source .txt file should be selected for reading. Then it reads the objects from the file and writes to the list
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // dialog box for selecting a file to read data
            ofd.Filter = "Text file|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Product.ResetProductCounter();
                FormMenu.productList.Clear();
                FormMenu.bookList.Clear();
                FormMenu.gameList.Clear();
                StreamReader sr = new StreamReader(ofd.FileName); // open the file for reading

                try
                {
                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();
                        if (line == "== book ==") // an auxiliary line to know what class the object to create
                        {
                            Book b1 = new Book();
                            b1.ReadFromFile(sr);
                            FormMenu.productList.Add(b1);
                            FormMenu.bookList.Add(b1);
                        }
                        else if (line == "== game ==") // an auxiliary line to know what class the object to create
                        {
                            Game g1 = new Game();
                            g1.ReadFromFile(sr);
                            FormMenu.productList.Add(g1);
                            FormMenu.gameList.Add(g1);
                        }
                    }
                }
                catch (FormatException)
                {
                    FormMenu.productList.Clear();
                    FormMenu.bookList.Clear();
                    FormMenu.gameList.Clear();
                    MessageBox.Show("Failed to load the data - FormatException.");
                }
                catch (IOException)
                {
                    FormMenu.productList.Clear();
                    FormMenu.bookList.Clear();
                    FormMenu.gameList.Clear();
                    MessageBox.Show("Failed to load the data - IOException.");
                }
                sr.Close();
                formImport.ShowDialog(); // display a form that shows what data has been imported            
            }
            else
            {
                MessageBox.Show("Failed to load the data.");
            }
        }

        // button to exit the program, when clicked it will display a MessageBox asking for confirmation
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure want to exit?", "Confiramtion", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            if (res == DialogResult.OK)
            {
                this.Close();
            }    
        }
    }
}