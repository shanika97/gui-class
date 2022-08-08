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
    public partial class Bookwindow : Form
    {
        public Bookwindow()
        {
            InitializeComponent();
        }

        private void butview_Click(object sender, EventArgs e)
        {

            if (txtAuthor.Text == " " || txtBname.Text == "" || txtno.Text == "" || txtISBN.Text=="" || txtSubject.Text=="")
            {
                MessageBox.Show("must fill all felids ", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BOOK books = new BOOK();
                books.AuthorName = txtAuthor.Text;
                books.NmaeBook = txtBname.Text;
                books.NoOFBOOKs = Convert.ToInt32(txtno.Text);
                books.Subject = txtSubject.Text;
                books.ISBN = Convert.ToInt32(txtISBN.Text);


                MessageBox.Show("Book: " + books.NmaeBook + "\n Author: " + books.AuthorName + "\n No of copies: " + books.NoOFBOOKs+"\n ISBN NO: "+books.ISBN+ "\n subject : "+books.Subject, "Details: ");


                txtAuthor.Text = "";
                txtBname.Text = "";
                txtno.Text = "";
                txtISBN.Text = "";
                txtSubject.Text = "";


                /* string Bname = txtBname.Text;
                string Aname = txtAuthor.Text;
                int NoOfCopies = Convert.ToInt32(txtno.Text);*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           staffwindow sf = new staffwindow();
            sf.Show();
            Hide();
        }

        private void butcatlog_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }
    }
    }

