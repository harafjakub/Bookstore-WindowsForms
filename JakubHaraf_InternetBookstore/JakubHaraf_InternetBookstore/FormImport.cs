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
    public partial class FormImport : Form
    {
        // constructor of the FormImport class
        public FormImport()
        {
            InitializeComponent();
            Load += new EventHandler(FormDisplayLoad); // when the form is loaded, it calls the method FormDisplayLoad
        }

        // method displaying how many products are on the list, and displaying them all in the list box
        private void FormDisplayLoad(object sender, System.EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            int productQuantity = 0;
            foreach (Product p in FormMenu.productList)
            {
                p.Write(listBoxDisplay);
                productQuantity++;
            }
            labelNumOfAddedProducts.Text = Convert.ToString(productQuantity) + " products.";
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
