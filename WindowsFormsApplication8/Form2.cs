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
        

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + x.data; // this to show the data
            textBox2.Text = "" + x.name;// this to show the name
             x = x.next; 
            if (x == null) // if that node was the last node the button next will be hide
            {
                button1.Visible = false;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            Form2 h = new Form2(); // this to make another form2 to show informantion
            h.x = x; // this to send the next node and step to the next node at line 28 in load form2 method up
            h.Show();// this to show the next form2
            // note: we shows to make every time another form to make it possible to close the other form without close the all form
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
