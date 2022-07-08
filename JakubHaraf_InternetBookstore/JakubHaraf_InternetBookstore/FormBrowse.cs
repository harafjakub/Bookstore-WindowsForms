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
    public partial class FormBrowse : Form
    {
        FromPictureViewer fromPictureViewer = new FromPictureViewer(); // from to display an enlarged cover
        int currentIndex; // field pointing to the current list item

        // constructor of the FormBrowse class
        public FormBrowse()
        {
            InitializeComponent();
            Load += new EventHandler(FormDisplayLoad); // when the form is loaded, it calls the method FormDisplayLoad
        }

        // method called each time the form is loaded, resetting the form
        private void FormDisplayLoad(object sender, System.EventArgs e)
        {
            ResetForm();
        }

        // method changing the list and checboxes to the default value, updating the displayed list, number of items and id pointing to the item to be deleted
        private void ResetForm()
        {
            FormMenu.tempList = new List<Product>(FormMenu.productList);
            checkBoxBooks.Checked = true;
            checkBoxGames.Checked = true;
            UpdateDisplayedList();
            SummaryOfProducts();
        }

        // method automatically changing the id number of the object to be deleted
        private void ChangeDeleteId()
        {
            if (currentIndex >= 0)
            {
                numericUpDownId.Value = FormMenu.tempList[currentIndex].GetProductId();
            }
            else
            {
                numericUpDownId.Value = 0;
            }
        }

        // method updating currently displayed list, currentIndex value, changing values "​​from" and "to", changing the id number of the object to be deleted and updating buttons
        private void UpdateDisplayedList()
        {
            listBoxDisplay.Items.Clear();

            if (FormMenu.tempList.Count > 0)
            {
                currentIndex = 0;
                FormMenu.tempList[currentIndex].Write(listBoxDisplay, pictureBoxCover);
            }
            else
            {
                currentIndex = -1;
                listBoxDisplay.Items.Add("No products in the store");
                pictureBoxCover.Image = null;
            }

            labelNumberFromValue.Text = Convert.ToString(currentIndex + 1);
            labelNumberToValue.Text = Convert.ToString(FormMenu.tempList.Count);
            ChangeDeleteId();
            UpdateButtons();
        }

        // method listing the current number of products, books and games in the bookstore on a form 
        private void SummaryOfProducts()
        {
            int numOfBooks = 0;
            int numOfGames = 0;

            for (int i = 0; i <= FormMenu.productList.Count - 1; i++)
            {
                if (FormMenu.productList[i] is Book)
                {
                    numOfBooks++;
                }
                else if (FormMenu.productList[i] is Game)
                {
                    numOfGames++;
                }
            }

            labelNumOfProductsValue.Text = Convert.ToString(FormMenu.productList.Count);
            labelNumOfBooksValue.Text = Convert.ToString(numOfBooks);
            labelNumOfGamesValue.Text = Convert.ToString(numOfGames);
        }

        // method for updating availability of next and previous buttons
        private void UpdateButtons()
        {
            // first element in the list
            if (currentIndex == 0)
            {
                buttonPrevious.Enabled = false;
            }
            else
            {
                buttonPrevious.Enabled = true;
            }

            // last element in the list
            if (currentIndex >= FormMenu.tempList.Count - 1)
            {
                buttonNext.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
            }

            // nothing in the list
            if (currentIndex < 0)
            {
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = false;
            }
            labelNumberFromValue.Text = Convert.ToString(currentIndex + 1);
        }

        // button that will change the product displayed on the listbox to the previous one
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            currentIndex--;
            listBoxDisplay.Items.Clear();
            FormMenu.tempList[currentIndex].Write(listBoxDisplay, pictureBoxCover);
            numericUpDownId.Value = FormMenu.tempList[currentIndex].GetProductId();
            UpdateButtons();
        }

        // button that will change the product displayed on the listbox to the next one
        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            listBoxDisplay.Items.Clear();
            FormMenu.tempList[currentIndex].Write(listBoxDisplay, pictureBoxCover);
            numericUpDownId.Value = FormMenu.tempList[currentIndex].GetProductId();
            UpdateButtons();
        }

        // button that introduces the filters specified in the checkboxes, by changing the tempList to a specific list with all products, only books, only games
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            // all products
            if (checkBoxBooks.Checked == true && checkBoxGames.Checked == true)
            {
                FormMenu.tempList = new List<Product>(FormMenu.productList);
                UpdateDisplayedList();
            }
            // only books
            else if (checkBoxBooks.Checked == true && checkBoxGames.Checked == false)
            {
                FormMenu.tempList = new List<Product>(FormMenu.bookList);
                UpdateDisplayedList();
            }
            // only games
            else if (checkBoxBooks.Checked == false && checkBoxGames.Checked == true)
            {
                FormMenu.tempList = new List<Product>(FormMenu.gameList);
                UpdateDisplayedList();
            }
            // nothing
            else
            {
                FormMenu.tempList = new List<Product>();
                UpdateDisplayedList();
            }
            MessageBox.Show("The filters are applied.");
        }

        // button checks if the product with such id is on the prodcutList, if so, checks if it is a book or a game, and then deletes the object on the prodcutList and on the bookList or gameList, then resets the form
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool idExsist = false;
            int remeberId = 0;
            int temp = Convert.ToInt32(numericUpDownId.Value);

            for (int i = 0; i <= FormMenu.productList.Count - 1; i++) // checks if a product with this id exists on porductList
            {
                if(FormMenu.productList[i].GetProductId() == temp)
                {
                    idExsist = true;
                    remeberId = i;
                }
            }

            if (idExsist) // removes the product from the prodcutList and from the bookList if it is a book, or from the gameList if it is a game
            {
                if (FormMenu.productList[remeberId] is Book)
                {
                    for (int i = 0; i <= FormMenu.bookList.Count - 1; i++)
                    {
                        if (FormMenu.bookList[i].GetProductId() == temp)
                        {
                            FormMenu.bookList.Remove(FormMenu.bookList[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= FormMenu.gameList.Count - 1; i++)
                    {
                        if (FormMenu.gameList[i].GetProductId() == temp)
                        {
                            FormMenu.gameList.Remove(FormMenu.gameList[i]);
                        }
                    }
                }
                FormMenu.productList.RemoveAt(remeberId);
                ResetForm();
            }
            else
            {
                MessageBox.Show("There is no product to delete.");
            }
        }

        // when mouse double-click the pictureBoxCover, a new form with an enlarged cover opens 
        private void pictureBoxCover_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FromPictureViewer fromPictureViewer = new FromPictureViewer();
            fromPictureViewer.BackgroundImage = pictureBoxCover.Image;
            fromPictureViewer.ShowDialog();
        }

        // when hover the mouse over the groupBoxSummary area, a new form will be displayed with the title of the items, id and whether it is a book or a game
        private void groupBoxSummary_MouseHover(object sender, EventArgs e)
        {
            FormDisplayAllProducts formDisplayAllProducts = new FormDisplayAllProducts();
            formDisplayAllProducts.ShowDialog();
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
