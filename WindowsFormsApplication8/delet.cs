using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class delet : Form
    {
        list r;
        public delet(list o)
        {
            r = o;
            InitializeComponent();
        }

        private void delet_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = 0;
            try { d = int.Parse(textBox1.Text); } catch { MessageBox.Show("error"); return; }
            r.deletnode(d); // this to send the data we put into the textbox and send it to method delet in the class list
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
