using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Book
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            flowLayoutPanel3.Visible = false;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
           
                if (File.Exists(Program.Default+@"\Student\"+Program.Aname+@"\MyBook.txt"))
                {
                    string[] MB = File.ReadAllLines(Program.Default + @"\Student\" + Program.Aname + @"\MyBook.txt");
                    for (int i = 0; i < MB.Length; i++)
                    {
                        string[] MB2 = MB[i].Split('\t');
                        Button BB = new Button() { 
                        Name=MB2[0],
                        FlatStyle=FlatStyle.Flat,
                        Font=new Font("Century Gothic",9),
                        Size =new Size(80,80),
                        BackColor=Color.Tomato,
                        ForeColor=SystemColors.ButtonHighlight,
                        Cursor=Cursors.Hand,
                        Text=MB2[1],
                        };
                        flowLayoutPanel3.Controls.Add(BB);
                        BB.MouseClick += BB_MouseClick;
                    }
                }
            
            
            
            
            if (File.Exists(Program.Default+@"\Admin.txt"))
            {
                string[] libraries = File.ReadAllLines(Program.Default + @"\Admin.txt");
                for (int i = 0; i < libraries.Length; i++)
                {
                    Button B = new Button() { 
                    Name=libraries[i],
                    Size=new Size(100,100),
                    BackColor=Color.DarkSalmon,
                    ForeColor=SystemColors.ButtonHighlight,
                    Text=libraries[i],
                    FlatStyle=FlatStyle.Flat,
                    Cursor=Cursors.Hand,
                    
                    };
                    flowLayoutPanel2.Controls.Add(B);
                    B.MouseClick += B_MouseClick;
                }
            }
        }

        void BB_MouseClick(object sender, MouseEventArgs e)
        {
            Program.PDF = ((Button)sender).Name;
            PDF PP = new PDF();
            PP.Show();
        }

        void B_MouseClick(object sender, MouseEventArgs e)
        {
            Program.Server = "STLogIn";
            Program.Dir =Program.Default+ @"\Admin\" + ((Control)sender).Name+@"\";
            this.Close();
        }

        private void DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.Server=="STLogIn")
            {
                Library lib = new Library();
                lib.Show();
            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Visible = true;
            
        }
    }
}
