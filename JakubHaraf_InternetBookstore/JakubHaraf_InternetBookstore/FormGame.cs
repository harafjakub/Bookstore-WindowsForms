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
    public partial class FormGame : Form
    {
        Bitmap bitmap = new Bitmap(Properties.Resources.nophoto); // creating a bitamp object and assigning it a default value

        // constructor of the FormGame class
        public FormGame()
        {
            InitializeComponent();
            pictureBoxUploadingCover.Image = bitmap; // displaying the default value of a bitmap object in the picturebox immediately after creating the FormGame object
            dateTimePickerReleaseDate.Value = DateTime.Now;
            dateTimePickerAddedDate.Value = DateTime.Now;
        }

        // button that adds a new Game object, adds it to the list of products and list of games, then enters data about the object in the listbox and displays the cover photo in the picturebox
        private void buttonAddGame_Click(object sender, EventArgs e)
        {    
            Game g1 = new Game(textBoxTitle.Text, textBoxAuthor.Text, textBoxPublisher.Text, TextBoxToArray(textBoxGenre), textBoxSeries.Text, dateTimePickerReleaseDate.Value,
                               dateTimePickerAddedDate.Value ,(float)numericUpDownPrice.Value, (float)numericUpDownRating.Value, Convert.ToInt32(numericUpDownSoldTitles.Value), 
                               checkBoxAvailable.Checked, textBoxDescription.Text, bitmap, TextBoxToArray(textBoxDubbingLanguage), TextBoxToArray(textBoxSubtitleLanguage), 
                               Convert.ToInt32(numericUpDownPegi.Value), comboBoxPlatform.Text, checkBoxSinglePlayer.Checked, checkBoxMultiPlayer.Checked);
            FormMenu.productList.Add(g1);
            FormMenu.gameList.Add(g1);
            listBoxDisplay.Items.Clear();
            FormMenu.productList[FormMenu.productList.Count - 1].Write(listBoxDisplay, pictureBoxCover);
            ClearDataLoadingObjects();
            MessageBox.Show("The game has been added");
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
            textBoxTitle.Text = "The Witcher 3: Wild Hunt";
            textBoxAuthor.Text = "CD Projekt RED";
            textBoxPublisher.Text = "cdp.pl";
            textBoxGenre.Text = "RPG";
            textBoxSeries.Text = "The Witcher";
            dateTimePickerReleaseDate.Value = new DateTime(2015, 5, 19);
            dateTimePickerAddedDate.Value = DateTime.Now;
            numericUpDownPrice.Value = (decimal)72.93;
            numericUpDownRating.Value = (decimal)9.6;
            numericUpDownSoldTitles.Value = 7453;
            checkBoxAvailable.Checked = true;
            textBoxDescription.Text = "The Witcher 3: Wild Hunt is the third and final installment in the series of games featuring the witcher Geralt of Rivia";
            textBoxDubbingLanguage.Text = "English,Polish";
            textBoxSubtitleLanguage.Text = "English,Polish,Germany";
            numericUpDownPegi.Value = 18;
            comboBoxPlatform.Text = "PC";
            checkBoxSinglePlayer.Checked = true;
            checkBoxMultiPlayer.Checked = false;
            bitmap = new Bitmap(Properties.Resources.witcher3);
            pictureBoxUploadingCover.Image = bitmap;
            labelPath.Text = "project/properties/resources/witcher3.jpg";
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
            textBoxDubbingLanguage.Clear();
            textBoxSubtitleLanguage.Clear();
            numericUpDownPegi.Value = 3;
            comboBoxPlatform.Text = "";
            checkBoxSinglePlayer.Checked = false;
            checkBoxMultiPlayer.Checked = false;
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

        // button that allows the user to load a photo from the device
        private void buttonUploadCover_Click(object sender, EventArgs e)
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

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}