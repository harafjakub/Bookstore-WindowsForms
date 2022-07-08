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
    public partial class FormStatistics : Form
    {
        // constructor of the FormStatistics class
        public FormStatistics()
        {
            InitializeComponent();
            Load += new EventHandler(FormDisplayLoad); // when the form is loaded, it calls the method FormDisplayLoad
        }

        // method called each time the form is loaded, updating the displayed statistics
        private void FormDisplayLoad(object sender, System.EventArgs e)
        {
            if (FormMenu.productList.Count > 0)
            {
                try
                {
                    labelAvgPrice.Text = Convert.ToString(Product.AvgPrice()) + " zł";
                    labelAvgRating.Text = Convert.ToString(Product.AvgRating());
                    labelAvgNumOfProducts.Text = Convert.ToString(Product.AvgNumOfProducts());
                    labelGenCapital.Text = Convert.ToString(Product.GenCapital()) + " zł";
                }
                catch (StackOverflowException)
                {
                    MessageBox.Show("Error - Stack overflow.");
                }             
            }
            else
            {
                labelAvgPrice.Text = "no products in the bookstore";
                labelAvgRating.Text = "no products in the bookstore";
                labelAvgNumOfProducts.Text = "no products in the bookstore";
                labelGenCapital.Text = "no products in the bookstore";
            }
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
