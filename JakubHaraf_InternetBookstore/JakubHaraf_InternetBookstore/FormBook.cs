using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubHaraf_InternetBookstore
{
    public partial class FormBook : Form
    {
        Bitmap bitmap = new Bitmap(Properties.Resources.nophoto); // creating a bitamp object and assigning it a default value

        // constructor of the FormBook class
        public FormBook()
        {
            InitializeComponent();
            pictureBoxUploadingCover.Image = bitmap; // displaying the default value of a bitmap object in the picturebox immediately after creating the FormGame object
            dateTimePickerReleaseDate.Value = DateTime.Now;
            dateTimePickerAddedDate.Value = DateTime.Now;
        }

        // button that adds a new Book object, adds it to the list of products and list of books, then enters data about the object in the listbox and displays the cover photo in the picturebox
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book b1 = new Book(textBoxTitle.Text, textBoxAuthor.Text, textBoxPublisher.Text, TextBoxToArray(textBoxGenre), textBoxSeries.Text, dateTimePickerReleaseDate.Value,
                               dateTimePickerAddedDate.Value, (float)numericUpDownPrice.Value, (float)numericUpDownRating.Value, Convert.ToInt32(numericUpDownSoldTitles.Value), 
                               checkBoxAvailable.Checked,textBoxDescription.Text, bitmap, Convert.ToInt32(numericUpDownPages.Value), new int[] { Convert.ToInt32(numericUpDownX.Value),
                               Convert.ToInt32(numericUpDownY.Value), Convert.ToInt32(numericUpDownZ.Value) }, comboBoxFormat.Text, textBoxOriginalLanguage.Text, 
                               textBoxReleaseLanguage.Text, maskedTextBoxIsbn.Text);
            FormMenu.productList.Add(b1);
            FormMenu.bookList.Add(b1);
            listBoxDisplay.Items.Clear();
            FormMenu.productList[FormMenu.productList.Count - 1].Write(listBoxDisplay, pictureBoxCover);
            ClearDataLoadingObjects();
            MessageBox.Show("The book has been added");
        }

        // method splitting the text given in the textbox into array elements, where the elements are separated by ","
        private string[] TextBoxToArray(TextBox t1)
        {
            string[] elements = t1.Text.Split(',');
            return elements;
        }

        // button that fills textboxes and other data reading objects with sample data
        private void buttonAutofill_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "The Lord of the Rings: The Fellowship of the Ring";
            textBoxAuthor.Text = "J. R. R. Tolkien";
            textBoxPublisher.Text = "George Allen & Unwin";
            textBoxGenre.Text = "Fantasy";
            textBoxSeries.Text = "Lord of the Rings";
            dateTimePickerReleaseDate.Value = new DateTime(1954, 7, 29);
            dateTimePickerAddedDate.Value = DateTime.Now;
            numericUpDownPrice.Value = (decimal)30.05;
            numericUpDownRating.Value = (decimal)8.4;
            numericUpDownSoldTitles.Value = 1004;
            checkBoxAvailable.Checked = true;
            textBoxDescription.Text = "The Fellowship of the Ring is the fist of three volumes of the epic novel The Lord of the Rings";
            numericUpDownPages.Value = 504;
            numericUpDownX.Value = 170;
            numericUpDownY.Value = 242;
            numericUpDownZ.Value = 48;
            comboBoxFormat.Text = "Soft cover";
            textBoxOriginalLanguage.Text = "English";
            textBoxReleaseLanguage.Text = "English";
            maskedTextBoxIsbn.Text = "2239768327535";
            bitmap = new Bitmap(Properties.Resources.LOTR_1);
            pictureBoxUploadingCover.Image = bitmap;
            labelPath.Text = "project/properties/resources/LOTR_1.jpg";
        }

        // method for cleaning textboxes and other data reading objects
        private void ClearDataLoadingObjects()
        {
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            textBoxPublisher.Clear();
            textBoxGenre.Clear();
            textBoxSeries.Clear();
            dateTimePickerReleaseDate.Value = DateTime.Now;
            dateTimePickerAddedDate.Value = DateTime.Now;
            numericUpDownPrice.Value = 1;
            numericUpDownRating.Value = 1;
            numericUpDownSoldTitles.Value = 0;
            checkBoxAvailable.Checked = false;
            textBoxDescription.Clear();
            numericUpDownPages.Value = 1;
            numericUpDownX.Value = 1;
            numericUpDownY.Value = 1;
            numericUpDownZ.Value = 1;
            comboBoxFormat.Text = "";
            textBoxOriginalLanguage.Clear();
            textBoxReleaseLanguage.Clear();
            maskedTextBoxIsbn.Clear();
            bitmap = new Bitmap(Properties.Resources.nophoto);
            pictureBoxUploadingCover.Image = bitmap;
            labelPath.Text = "No file selected";
        }

        // button that cleans the listbox and sets the default image for picturebox
        private void buttonClearField_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            pictureBoxCover.Image = null;
        }

        // button that clears all textboxes and data-loading objects
        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            ClearDataLoadingObjects();
        }

        // System.ArgumentException

        // button that allows the user to load a photo from the device
        private void buttonUploadCover_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFile.FileName;
                    bitmap = new Bitmap(fileName);
                    labelPath.Text = fileName;
                    pictureBoxUploadingCover.Image = bitmap;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Failed to upload the cover photo - ArgumentException.");
            }
        }

        // Button that adds 3 new books to the product list
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            ClearDataLoadingObjects();

            Book b1 = new Book("The Lord of the Rings: The Two Towers", "J. R. R. Tolkien", "George Allen & Unwin", new string[] { "Fantasy" }, "Lord of the Rings", new DateTime(1954, 11, 11), DateTime.Now, (float)30.5, (float)8.5, 934, true, "The Two Towers is the second volume of J. R. R. Tolkien's high fantasy novel The Lord of the Rings", new Bitmap(Properties.Resources.LOTR_2), 439, new int[] { 167, 242, 43 }, "Soft cover", "English", "English", "2265566096445");
            FormMenu.productList.Add(b1);
            FormMenu.bookList.Add(b1);
            FormMenu.productList[FormMenu.productList.Count - 1].Write(listBoxDisplay, pictureBoxCover);
            listBoxDisplay.Items.Add("");

            Book b2 = new Book("The Lord of the Rings: The Return of the King", "J. R. R. Tolkien", "George Allen & Unwin", new string[] { "Fantasy" }, "Lord of the Rings", new DateTime(1955, 10, 20), DateTime.Now, (float)36.8, (float)8.6, 765, true, "The Return of the King is the third and final volume of J. R. R. Tolkien's The Lord of the Rings, following The Fellowship of the Ring and The Two Towers", new Bitmap(Properties.Resources.LOTR_3), 368, new int[] { 167, 241, 53 }, "Soft cover", "English", "English", "2265571411290");
            FormMenu.productList.Add(b2);
            FormMenu.bookList.Add(b2);
            FormMenu.productList[FormMenu.productList.Count - 1].Write(listBoxDisplay, pictureBoxCover);
            listBoxDisplay.Items.Add("");

            Book b3 = new Book("Stary człowiek i morze", "Hemingway Ernest", "Wydawnictwo Marginesy", new string[] { "Story" }, "-", new DateTime(1952, 1, 1), DateTime.Now, (float)39.9, (float)6.2, 247, false, "Set in the Gulf Stream off the coast of Havana, Hemingway's magnificent fable is the tale of an old man, a young boy and a giant fish", new Bitmap(Properties.Resources.SCiM), 368, new int[] { 160, 100, 10 }, "Hard cover", "English", "Polish", "8241239542304");
            FormMenu.productList.Add(b3);
            FormMenu.bookList.Add(b3);
            FormMenu.productList[FormMenu.productList.Count - 1].Write(listBoxDisplay, pictureBoxCover);
            listBoxDisplay.Items.Add("");

            MessageBox.Show("The 3 books has been added");
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
