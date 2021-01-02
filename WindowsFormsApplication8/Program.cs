using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{ public class node
    {
        public String name;
        public int data;
      
        public  node next;

      


    }
    public class list
    {
        public int z=0;
            
        public  int y = 0;
      
        public list()
        {

            pp = head;
            p = head;

        }
      
        public  node pp,p;
        public node head;
        public void deletnode(int d)
        { 

            pp = head;
            node s=null;
            if (head.data == d)
            {
                head = head.next;
                return;
            }
            while (d != pp.data)
            {
                s = pp;
                
                pp = pp.next;
                if (pp==null)
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
            //if (pp.next == null && p.data != d)
            //{
            //    MessageBox.Show("the node is node exisit or the is no list");
            //    return;
            //}

            s.next = pp.next;

            pp.next = null;
            MessageBox.Show("the node is deleted");
        }
        public void addtoend(int data,string name)
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


            ////int y = 0;
            ////pp = head;
            //// Form2 x = new Form2();
            ////while (pp != null)
            ////{
            ////    y++;
            ////    if (pp.next == null)
            ////    {
            ////        MessageBox.Show("the only worker is id : " + pp.data+" his name is: "+pp.name);

            ////        return;
            ////    }
            ////    MessageBox.Show("the  worker is : " + pp.data + " his name is :" + pp.name);
            ////    pp = pp.next;
                
            ////}
            ////if(head==null)
            ////MessageBox.Show("no list created ");



            //// Button b = new Button();



            // if (y == 0)
            // {
            //     this.pp = head;
            //     y++;
            // }
            // else
            // {

            //     pp = p;
            // }

            // if (head == null)
            // {
            //     show r = new show();
            //     TextBox tx = new TextBox();
            //     pp = head;
            //   r..Text = "list is empty";

            //     r.Controls.Add(tx);
            //     r.Show();



            //     return;


            // }

            // if (pp.next == null)
            // {
            //     Form r = new Form();
            //     TextBox tx = new TextBox();

            //     tx.Text = "" +pp.data;
            //     r.Controls.Add(tx);

            //     r.Show();


            //     return;
            // }
            // if (pp != null)
            // {

            //     Form r = new Form();
            //     TextBox tx = new TextBox();
            //     tx.Top = 50;
            //     tx.Left = 70;

            //     b.Top = 150;
            //     b.Left = 170;
            //     b.Text = "next";
            //     tx.Text = ""+pp.data;
            //     r.Controls.Add(tx);
            //     b.Click += new System.EventHandler(this.k);
            //     r.Controls.Add(b);
            //     r.Controls.Add(tx);
            //     r.Show();




            // }

            // b.Hide();

        }
        //} private void k(object sender, EventArgs e)
        //{
            
        //    z++;
        //  node  s = pp.next;
        //    next(s);

        //}
       

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
