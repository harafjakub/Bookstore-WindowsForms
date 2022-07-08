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
    public partial class FormDisplay : Form
    {
        // constructor of the FormDisplay class
        public FormDisplay()
        {
            InitializeComponent();
            Load += new EventHandler(FormDisplayLoad); // when the form is loaded, it calls the method FormDisplayLoad
        }

        // method called each time the form is loaded, resetting the form
        private void FormDisplayLoad(object sender, System.EventArgs e)
        {
            ResetListView(FormMenu.productList);
            FormMenu.tempList = new List<Product>(FormMenu.productList);
            checkBoxActiveText.Checked = false;
            checkBoxActiveRange.Checked = false;
        }

        // method resets the displayed list in listViewProducts to the one passed as a parameter
        private void ResetListView(List<Product> tempList)
        {
            listViewProducts.Items.Clear();
            foreach (Product product in tempList)
            {
                var row = product.FieldsToStringArray();
                var lvi = new ListViewItem(row);
                lvi.Tag = product;
                listViewProducts.Items.Add(lvi);
            }
            listViewProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewProducts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        // button that sorts the list according to specific criteria and then displays it in listViewProducts
        private void buttonSort_Click(object sender, EventArgs e)
        {
            FormMenu.productList.Sort();
            listViewProducts.Items.Clear();
            ResetListView(FormMenu.productList);
        }

        // button restoring the list to the version that was when FormDisplay was opened
        private void buttonResetSort_Click(object sender, EventArgs e)
        {
            ResetListView(FormMenu.tempList);
            FormMenu.productList = new List<Product>(FormMenu.tempList);
        }

        // button that searches the list of products that match the parameters provided by the user in the form and displays it in the listViewProducts
        private void buttonFind_Click(object sender, EventArgs e)
        {
            // title and price criteria
            if (checkBoxActiveText.Checked && checkBoxActiveRange.Checked)
            {
                List<Product> searchResults = FormMenu.productList
                    .Where(a => a.WhereTitle(textBoxTextPhrase.Text))
                    .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownPriceFrom.Value), Convert.ToInt32(numericUpDownPriceTo.Value)))
                    .ToList();

                ResetListView(searchResults); 
            }
            // title criteria
            else if (checkBoxActiveText.Checked)
            {
                List<Product> searchResults = FormMenu.productList
                    .Where(a => a.WhereTitle(textBoxTextPhrase.Text))
                    .ToList();

                ResetListView(searchResults);
            }
            // price criteria
            else if (checkBoxActiveRange.Checked)
            {
                List<Product> searchResults = FormMenu.productList
                    .Where(a => a.WherePrice(Convert.ToInt32(numericUpDownPriceFrom.Value), Convert.ToInt32(numericUpDownPriceTo.Value)))
                    .ToList();

                ResetListView(searchResults);
            }
            // no criteria
            else
            {
                ResetListView(FormMenu.productList);
            }
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
