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
    public partial class FormDisplayAllProducts : Form
    {
        // constructor of the FormDisplayAllProducts class
        public FormDisplayAllProducts()
        {
            InitializeComponent();
            Load += new EventHandler(FormDisplayLoad); // when the form is loaded, it calls the method FormDisplayLoad
        }

        // method displaying the titles and id of all products on the productList in the list box, including whether it is a book or a game
        private void FormDisplayLoad(object sender, System.EventArgs e)
        {
            Product.DisplayShortcutOfProducts(listBoxDisplay);
        }
    }
}
