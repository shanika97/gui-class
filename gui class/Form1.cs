using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_class
{
   

    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }

        private void butview_Click(object sender, EventArgs e)
        {
            
            
            if (txtAuthor.Text==" " || txtBname.Text=="" || txtno.Text == "") {
                MessageBox.Show( "must fill all felids ", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Catalog cat = new Catalog();
                cat.AName       = txtAuthor.Text;
                cat.Bname       = txtBname.Text;
                cat.NoOfCopies  = Convert.ToInt32(txtno.Text);


                MessageBox.Show("Book: " + cat.Bname + "\n Author: " + cat.AName + "\n No of copies: " + cat.NoOfCopies, "Details: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                txtAuthor.Text = "";
                txtBname.Text = "";
                txtno.Text = "";

                /* string Bname = txtBname.Text;
                string Aname = txtAuthor.Text;
                int NoOfCopies = Convert.ToInt32(txtno.Text);*/

               
                Form2 frm2 = new Form2(cat.AName,cat.Bname);
                frm2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookwindow book = new Bookwindow();
            book.Show();
            Hide();
          
        }
    }
}
