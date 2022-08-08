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
    public partial class Form2 : Form
    {

        public Form2(string bname,string aname)
        {
            InitializeComponent();
            txtrichTextBox1.Text = bname;
            txtrichTextBox1.Text = aname;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
