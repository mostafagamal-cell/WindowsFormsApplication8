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
    public partial class Form1 : Form
    {
     
      public Form1()
        {
           
            InitializeComponent();
        }
        list l = new list();
        public  void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            String name = textBox1.Text;
            bool o = System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$");

            if (name == null )
            {
                MessageBox.Show("erorr in user name");
                return;
            }
            if (int.TryParse(name, out a)  ) 
            {
                MessageBox.Show("erorr in user name");
                return;
            }
            if ( o != true) 
            {
                MessageBox.Show("erorr in user name");
                return;
            }

            int x=0;
            try { x = int.Parse(textBox2.Text); } catch { MessageBox.Show("error in the intered data");
                return;
            }
            if (x < 0) { MessageBox.Show("not allowed to inter mins value"); return; }
            
            l.addtoend(x,name);
            MessageBox.Show("saved");
        }

      private void button2_Click(object sender, EventArgs e)
        {

            l.next();
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.head = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            delet x = new delet(l);
            x.Show();

            
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
