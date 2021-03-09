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
    public partial class Admin_Library : Form
    {
        public Admin_Library()
        {
            InitializeComponent();
        }
        public int x = 0;
        private void Admin_Library_Load(object sender, EventArgs e)
        {
            if (Program.Server=="SignUp")
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
            }
            Program.Path = string.Empty;
            if (Program.count == 0)
            {


                if (File.Exists(Program.Dir + @"\Booksadd.txt"))
                {
                    string[] Bookslist = null;
                    Bookslist = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
                    for (int i = 0; i < Bookslist.Length; i++)
                    {
                        string[] div = Bookslist[i].Split('\t');
                        FlowLayoutPanel PP = new FlowLayoutPanel();
                        PP.Name = div[0];
                        PP.AutoSize = true;
                        PP.FlowDirection = FlowDirection.TopDown;
                        PP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                       
                        Label L = new Label();
                        L.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                        
                        PP.BorderStyle = BorderStyle.FixedSingle;
                        PP.Controls.Add(L);
                        Label L2 = new Label();
                        
                        for (int j = 1; j < div.Length; j++)
                        {
                            
                            L2.Font = new Font("Century Gothic", 9);
                            L2.Text = div[j];
                            
                            PP.Controls.Add(L2);
                           
                        }
                        
                        L.Text = div[0];
                        
                        
                        flowLayoutPanel2.Controls.Add(PP);
                        PP.MouseClick += PP_MouseClick;
                        PP.Cursor = Cursors.Hand;

                    }
                } 
            }


            if (Program.PermanentCategory!=null)
            {
                 
            
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source = new AutoCompleteStringCollection();
            source.AddRange(Program.PermanentCategory);
            textBox1.AutoCompleteCustomSource = source;
            }

            if (Program.count==0)
            {
                if (File.Exists(Program.Dir + @"\Book.txt"))
                {
                    Program.Category = File.ReadAllLines(Program.Dir + @"\Book.txt");
                    if (Program.Category != null)
                    {
                        for (int i = 0; i < Program.Category.Length; i++)
                        {
                            Button B = new Button()
                            {
                                Tag = i,
                                Text = Program.Category[i],
                                Size = new Size(122, 31),
                                Font = new Font("Century Gothic", 9),
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.Tomato,
                                ForeColor = SystemColors.ButtonHighlight,
                                Cursor = Cursors.Hand,
                            };
                            flowLayoutPanel1.Controls.Add(B);
                        }
                    }
            }
            
            }

            if (Program.count==1)
            {
                Program.Category = File.ReadAllLines(Program.Dir + @"\Book.txt");
               
                for (int k = 0; k < Program.Category.Length; k++)
                {
                    Button B = new Button()
                    {

                        Text = Program.Category[k],
                        Size = new Size(122, 31),
                        Font = new Font("Century Gothic", 9),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.Tomato,
                        ForeColor = SystemColors.ButtonHighlight,
                        Cursor = Cursors.Hand,
                    };
                    flowLayoutPanel1.Controls.Add(B);
                }
                }
                 if (Program.count==2)
            {
                FlowLayoutPanel FPP = new FlowLayoutPanel();
                FPP.Name = Program.bookn;
                FPP.AutoSize = true;
                FPP.FlowDirection = FlowDirection.TopDown;
                FPP.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                FPP.BorderStyle = BorderStyle.FixedSingle;
                Label L = new Label();
                L.Font = new Font("Century Gothic", 9, FontStyle.Bold);
                L.Text = FPP.Name;
                FPP.Cursor = Cursors.Hand;
                Label L2 = new Label();
                L2.Font = new Font("Century Gothic", 9);
                L2.Text = Program.author;
 FPP.Controls.Add(L2);
 L2.Font = new Font("Century Gothic", 9);
 L2.Text = Program.edition;
 FPP.Controls.Add(L2);
 L2.Font = new Font("Century Gothic", 9);
 L2.Text = Program.publisher;
 FPP.Controls.Add(L2);
 L2.Font = new Font("Century Gothic", 9);
 L2.Text = Program.Cat;
 FPP.Controls.Add(L2);
                     
                     
 FPP.MouseClick += FPP_MouseClick;

            }

        }

        void FPP_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        void PP_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

       
     

          

            void PB_MouseClick(object sender, MouseEventArgs e)
            {
                Booksadd ba = new Booksadd();
                ba.Show();
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                Category Cat = new Category();
                Cat.Show();
            }

            

            private void Admin_Library_VisibleChanged(object sender, EventArgs e)
            {
                
            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
                Booksadd BA = new Booksadd();
                BA.Show();
            }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }
                
            
       
       
       

       
    }
}
