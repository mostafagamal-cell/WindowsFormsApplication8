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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
       public  node x;
        public string t;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + x.data;
            textBox2.Text = "" + x.name;
            x = x.next;
            if (x == null)
            {
                button1.Visible = false;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (x==null)
            { 
                this.Close();
                return;
            }

            Form2 h = new Form2();
            h.x = x;
            h.Show();
            button1.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
