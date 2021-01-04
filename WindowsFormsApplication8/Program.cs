using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public class node
    {
        public String name;
        public int data;

        public node next;




    }
    public class list
    {
        public int z = 0;

        public int y = 0;

        public list()
        {

            pp = head;


        }

        public node pp;
        public node head;
        public void deletnode(int d)
        {

            pp = head;
            node s = null;
            if (head.data == d)
            {
                head = head.next;
                return;
            }
            while (d != pp.data)
            {
                s = pp;

                pp = pp.next;
                if (pp == null)
                {
                    MessageBox.Show("the node is node exisit or the is no list");
                    return;
                }

            }
            if (pp.next == null)
            {
                pp = null;

                return;
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
                node po = head;
                while (po.next != null)
                {

                    po = po.next;



                }
                po.next = s;


            }
        }




        public void next()
        {
            Form2 xf = new Form2();

            if (head == null)
            {
                MessageBox.Show("no onformation is recorded");

                return;

            }
            else
            {
                xf.x = head;
                xf.ShowDialog();




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