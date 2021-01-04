using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public class node //this is the node class that record information
    {
        public String name;
        public int data;

        public node next;




    }
    public class list // this is the list class that we do oparetion on the linkedlist
    {
      

        public node pp; // the pointer  
        public node head; // the head of the list
        public void deletnode(int d) 
        {

            pp = head;
            node s = null;
            if (head.data == d) //this happed when the deleted node is the 
            {
                head = head.next;
                MessageBox.Show("the node is was deleted and it was the frist node in the list");
                return;  // this to get out the method
            }
            while (d != pp.data)  //the loop continue untill it find the targeted node
            {
                s = pp;

                pp = pp.next;
                if (pp == null) // this happed if the node is not exist in list
                {
                    {
                        MessageBox.Show("the node is node exisit or the is no list");
                        return;
                    }

                }
                
            }


            s.next = pp.next;

            pp.next = null;
            MessageBox.Show("the node is deleted");
        }
        public void addtoend(int data, string name)
        {
            node s = new node();
            s.data = data;
            s.name = name;

            if (head == null)
            { head = s; }
            else
            {
                pp = head;
                while (pp.next != null)
                {

                    pp = pp.next;



                }
                pp.next = s;


            }
        }




        public void show() // this is the show method
        { 
            Form2 xf = new Form2(); // we take copy from form2 every time we show new node

            if (head == null) //this happenn if the there is nod list
            {
                MessageBox.Show("no information is recorded");

                return;

            }
            else
            {
                xf.x = head; // the send the node that have information to form2
                xf.ShowDialog(); // that to show the form2




            }




        }
        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}