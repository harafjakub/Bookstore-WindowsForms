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
    public partial class FormOperator : Form
    {
        Book b1, b2, b3; 
        int controlVar = 1; // variable that controls which object b1 or b2 the object from the list is to be written to
        int rememberPosition; // variable saving the position of the object in the product list in order to overwrite the object after the += operation

        // constructor of the FormOperator class
        public FormOperator()
        {
            InitializeComponent();
        }

        // method which checks which operator has been selected and if both given id's exist and belong to the book, it executes the particular operator
        private void buttonPerform_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();

            // method validating input data, if all ok then it performs == operation
            if (comboBoxOperator.Text == "==")
            {
                if (CheckIdExist(Convert.ToInt32(numericUpDownBookA.Value)) && CheckIdExist(Convert.ToInt32(numericUpDownBookB.Value)))
                {
                    listBoxDisplay.Items.Add("Operator result: " + (b1 == b2));
                    if (b1 == b2)
                    {
                        listBoxDisplay.Items.Add("The books are from a common series.");
                    }
                    else
                    {
                        listBoxDisplay.Items.Add("The books are not from a common series.");
                    }
                }
                else
                {
                    WhichIdWrong();
                }
            }

            // method validating input data, if all ok then it performs != operation
            else if (comboBoxOperator.Text == "!=")
            {
                if (CheckIdExist(Convert.ToInt32(numericUpDownBookA.Value)) && CheckIdExist(Convert.ToInt32(numericUpDownBookB.Value)))
                {
                    listBoxDisplay.Items.Add("Operator result: " + (b1 != b2));
                    if (b1 != b2)
                    {
                        listBoxDisplay.Items.Add("The books are not from a common series.");
                    }
                    else
                    {
                        listBoxDisplay.Items.Add("The books are from a common series.");
                    }
                }
                else
                {
                    WhichIdWrong();
                }
            }

            // method validating input data, if all ok then it performs + operation
            else if (comboBoxOperator.Text == "+")
            {
                if (CheckIdExist(Convert.ToInt32(numericUpDownBookA.Value)) && CheckIdExist(Convert.ToInt32(numericUpDownBookB.Value)))
                { 
                    b3 = b1 + b2;
                    FormMenu.productList.Add(b3);
                    FormMenu.bookList.Add(b3);
                    b3.Write(listBoxDisplay);
                    listBoxDisplay.Items.Add("");
                    b1.Write(listBoxDisplay);
                    listBoxDisplay.Items.Add("");
                    b2.Write(listBoxDisplay);
                }
                else
                {
                    WhichIdWrong();
                }
            }

            // method validating input data, if all ok then it performs += operation
            else if (comboBoxOperator.Text == "+=")
            {
                if (CheckIdExist(Convert.ToInt32(numericUpDownBookA.Value)) && CheckIdExist(Convert.ToInt32(numericUpDownBookB.Value)))
                {
                    b1.Write(listBoxDisplay);
                    listBoxDisplay.Items.Add("");
                    b1 += b2;
                    FormMenu.productList[rememberPosition] = b1;
                    b1.Write(listBoxDisplay);
                    listBoxDisplay.Items.Add("");
                    b2.Write(listBoxDisplay);
                    listBoxDisplay.Items.Add("");
                }
                else
                {
                    WhichIdWrong();
                }
            }
            else
            {
                MessageBox.Show("Unknown operator, make sure you select an operator from the list.");
            }
        }

        // bool method checking if the given id exists in the list of products and if so, if it is a book
        private bool CheckIdExist(int id)
        {
            bool exist = false;
            for (int i = 0; i <= FormMenu.productList.Count -1; i++)
            {
                if (id == FormMenu.productList[i].GetProductId()) 
                {
                    if (FormMenu.productList[i] is Book)
                    {
                        exist = true;
                        if (controlVar == 1)
                        {
                            b1 = FormMenu.productList[i] as Book;
                            rememberPosition = i;
                            controlVar = 2;
                        }
                        else if (controlVar == 2)
                        {
                            b2 = FormMenu.productList[i] as Book;
                            controlVar = 1;
                        }
                    }
                }
            }
            return exist;
        }

        // method to check which of the given id is wrong
        private void WhichIdWrong()
        {
            if (CheckIdExist(Convert.ToInt32(numericUpDownBookA.Value)))
            {
                MessageBox.Show("Book with id = " + Convert.ToInt32(numericUpDownBookB.Value) + " does not exist.");
            }
            else
            {
                MessageBox.Show("Book with id = " + Convert.ToInt32(numericUpDownBookA.Value) + " does not exist.");
            }
        }

        // button to return to the main menu
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
