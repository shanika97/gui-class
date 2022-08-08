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
    public partial class staffwindow : Form
    {
        public staffwindow()
        {
            InitializeComponent();
        }

        private void butcatlog_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bookwindow book = new Bookwindow();
            book.Show();
            Hide();
        }

        private void butview_Click(object sender, EventArgs e)
        {
            if (txtpw.Text == " " || txtid.Text == "")
            {
                MessageBox.Show("must fill all felids ", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                staff sf = new staff();
                sf.Id = txtid.Text;
                sf.Password = txtpw.Text;


                MessageBox.Show("ID: " + sf.Id, "Details: ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtpw.Text = "";
                txtid.Text = "";

            }
        }
    }
}

