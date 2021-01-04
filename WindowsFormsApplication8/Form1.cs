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
            bool o = System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"); // this method to test the information that was intered by user

           
            if ( o != true) // this to  show message this this problem in the name and stop saving name
            {
                MessageBox.Show("erorr in user name");
                return;
            }
            // this to  show message this this problem in the data and stop saving data
            int x =0;
            try { x = int.Parse(textBox2.Text); } catch { MessageBox.Show("error in the intered data");
                return;
            }
            if (x < 0) { MessageBox.Show("not allowed to inter mins value"); return; }
            
            l.addtoend(x,name); //this to add information to the list   
            MessageBox.Show("saved"); // this conferm the user that the information was saved in the list
        }

      private void button2_Click(object sender, EventArgs e)
        {

            l.show(); //this to go to method show at list class
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.head = null; // this to delet all list
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            delet x = new delet(l); // this make object from form delet and send the list (l) to its constractor
            x.Show(); //this to show the form

            
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
