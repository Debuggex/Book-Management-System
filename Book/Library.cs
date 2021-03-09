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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Library_Load(object sender, EventArgs e)
        {
            if (File.Exists(Program.Dir+@"\Booksadd.txt")==false)
            {
                button2.Enabled = false;
            }
            
            label1.Text = Program.Aname;
            if (Program.Server == "AdminLogin" || Program.Server == "STLogIn")
            {
                if (Program.Server=="STLogIn")
                {
                    flowLayoutPanel1.Hide();
                    panel2.Hide();
                }
                if (File.Exists(Program.Dir + @"\Book.txt"))
                {
                    string[] cate = File.ReadAllLines(Program.Dir + @"\Book.txt");
                    if (cate != null)
                    {
                        for (int i = 0; i < cate.Length; i++)
                        {
                            Button B = new Button()
                            {
                                Name = cate[i],
                                Size = new Size(99, 26),
                                Text = cate[i],
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.Tomato,
                                ForeColor = SystemColors.ButtonHighlight,
                                Font = new Font("Century Gothic", 9),
                                Cursor = Cursors.Hand,
                            };
                            flowLayoutPanel2.Controls.Add(B);
                            B.MouseClick += B_MouseClick;
                        }
                    }
                }
                    if (File.Exists(Program.Dir + @"\Booksadd.txt"))
                    {


                        string[] boadd = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
                        for (int i = 0; i < boadd.Length; i++)
                        {
                            string[] boadd2 = boadd[i].Split('\t');
                            FlowLayoutPanel P = new FlowLayoutPanel()
                            {
                                Name = boadd2[4],
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                FlowDirection = FlowDirection.TopDown,
                                Cursor = Cursors.Hand,
                                //BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.Tomato,
                                Size = new Size(319, 229),
                       
                            };
                            //P.MouseDoubleClick+=P_MouseDoubleClick;
                            //P.MouseClick+=P_MouseClick;
                            flowLayoutPanel3.Controls.Add(P);

                            Label L = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Bold),
                                Text = boadd2[0],
                                Margin=new Padding(0,25,0,25),
                                ForeColor=SystemColors.ButtonHighlight,
                                Size=new Size(298,23),
                           
                            };
                            
                            P.Controls.Add(L);

                            Label L2 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[1],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L2);

                            Label L3 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[2],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L3);
                            Label L4 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[3],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L4);
                            Label L5 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[5],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };
                            
                          //  P.Controls.Add(L5);
                            Program.Server = null;
                            P.MouseClick += P_MouseClick;
                            P.MouseDoubleClick += P_MouseDoubleClick;
                        }
                        string[] booadd2 = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");

                        string[] bookss = new string[booadd2.Length];
                        for (int i = 0; i < booadd2.Length; i++)
                        {
                            string[] booadd3 = booadd2[i].Split('\t');
                            bookss[i] = booadd3[0];
                        }
                        var source = new AutoCompleteStringCollection();
                        source.AddRange(bookss);
                        textBox1.AutoCompleteCustomSource = source;
                    }

                

            }


                if (Program.Server == "Category")
                {
                    if (File.Exists(Program.Dir+@"\Book.txt"))
                    {
                        
                    
                    //Button Creation
                    string[] cate = File.ReadAllLines(Program.Dir + @"\Book.txt");
                    if (cate != null)
                    {
                        for (int i = 0; i < cate.Length; i++)
                        {
                            Button B = new Button()
                            {
                                Name = cate[i],
                                Size = new Size(99, 26),
                                Text = cate[i],
                                FlatStyle = FlatStyle.Flat,
                                BackColor = Color.Tomato,
                                ForeColor = SystemColors.ButtonHighlight,
                                Font = new Font("Century Gothic", 9),
                                Cursor = Cursors.Hand,
                            };
                            flowLayoutPanel2.Controls.Add(B);
                            B.MouseClick += B_MouseClick;
                        }


                    }
                        //Books Addition
                    }
                    if (File.Exists(Program.Dir + @"\Booksadd.txt"))
                    {


                        string[] boadd = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
                        for (int i = 0; i < boadd.Length; i++)
                        {
                            string[] boadd2 = boadd[i].Split('\t');
                            FlowLayoutPanel P = new FlowLayoutPanel()
                            {
                                Name = boadd2[4],
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                FlowDirection = FlowDirection.TopDown,
                                Cursor = Cursors.Hand,
                                //BorderStyle = BorderStyle.FixedSingle,
                                BackColor = Color.Tomato,
                                Size = new Size(319, 229),
                            };

                            P.MouseDoubleClick += P_MouseDoubleClick;
                          //  P.MouseClick += P_MouseClick;
                            flowLayoutPanel3.Controls.Add(P);

                            Label L = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[0],
                                Margin = new Padding(0, 25, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };
                            P.Controls.Add(L);

                            Label L2 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[1],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L2);

                            Label L3 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[2],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L3);
                            Label L4 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[3],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L4);
                            Label L5 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[5],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                         //   P.Controls.Add(L5);
                            Program.Server = null;
                            P.MouseClick += P_MouseClick;
                        }
                        string[] booadd2 = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");

                        string[] bookss = new string[booadd2.Length];
                        for (int i = 0; i < booadd2.Length; i++)
                        {
                            string[] booadd3 = booadd2[i].Split('\t');
                            bookss[i] = booadd3[0];
                        }
                        var source = new AutoCompleteStringCollection();
                        source.AddRange(bookss);
                        textBox1.AutoCompleteCustomSource = source;
                    } 
                }


                if (Program.Server == "BooksAdd")
                {
                    if (File.Exists(Program.Dir + @"\Book.txt"))
                    {


                        //Button Creation
                        string[] cate = File.ReadAllLines(Program.Dir + @"\Book.txt");
                        if (cate != null)
                        {
                            for (int i = 0; i < cate.Length; i++)
                            {
                                Button B = new Button()
                                {
                                    Name = cate[i],
                                    Size = new Size(99, 26),
                                    Text = cate[i],
                                    FlatStyle = FlatStyle.Flat,
                                    BackColor = Color.Tomato,
                                    ForeColor = SystemColors.ButtonHighlight,
                                    Font = new Font("Century Gothic", 9),
                                    Cursor = Cursors.Hand,
                                };
                                B.MouseClick+=B_MouseClick;
                                flowLayoutPanel2.Controls.Add(B);
                            }
                        }

                    }
                    if (File.Exists(Program.Dir + @"\Booksadd.txt"))
                    {


                        string[] boadd = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
                        for (int i = 0; i < boadd.Length; i++)
                        {
                            string[] boadd2 = boadd[i].Split('\t');
                            FlowLayoutPanel P = new FlowLayoutPanel()
                            {
                                Name = boadd2[4],
                                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                                FlowDirection = FlowDirection.TopDown,
                                Cursor = Cursors.Hand,
                                BackColor = Color.Tomato,
                                //BorderStyle = BorderStyle.FixedSingle,
                                Size = new Size(319, 229),
                            };

                            P.MouseDoubleClick += P_MouseDoubleClick;
                           // P.MouseClick += P_MouseClick;
                            flowLayoutPanel3.Controls.Add(P);

                            Label L = new Label()
                            {
                                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                                Text = boadd2[0],
                                Margin = new Padding(0, 25, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };
                            P.Controls.Add(L);

                            Label L2 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[1],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L2);

                            Label L3 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[2],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L3);
                            Label L4 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[3],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                            P.Controls.Add(L4);
                            Label L5 = new Label()
                            {
                                Font = new Font("Century Gothic", 9, FontStyle.Regular),
                                Text = boadd2[5],
                                Margin = new Padding(0, 0, 0, 25),
                                ForeColor = SystemColors.ButtonHighlight,
                                Size = new Size(298, 23),
                            };

                         //   P.Controls.Add(L5);
                            Program.Server = null;
                            P.MouseClick += P_MouseClick;
                        }
                        string[] booadd2 = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");

                        string[] bookss = new string[booadd2.Length];
                        for (int i = 0; i < booadd2.Length; i++)
                        {
                            string[] booadd3 = booadd2[i].Split('\t');
                            bookss[i] = booadd3[0];
                        }
                        var source = new AutoCompleteStringCollection();
                        source.AddRange(bookss);
                        textBox1.AutoCompleteCustomSource = source;

                    } 
                }
                if (Program.Server != "STLogIn")
                {
                     Program.Server = null;
                }
               
            
        }

        void P_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.PDF = ((Panel)sender).Name;
            PDF U = new PDF();
            U.Show();
            U.BringToFront();
            
        }

        void B_MouseClick(object sender, MouseEventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            String SS = ((Button)sender).Name;
            string[] boadd = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
            for (int i = 0; i < boadd.Length; i++)
            {
                string[] boadd2 = boadd[i].Split('\t');
                if (boadd2[boadd2.Length-1]==SS)
                {
                    FlowLayoutPanel P = new FlowLayoutPanel()
                    {
                        Name = boadd2[4],
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        FlowDirection = FlowDirection.TopDown,
                        Cursor = Cursors.Hand,
                      //  BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.Tomato,  
                      Size = new Size(319, 229),
                    };

                   // P.MouseDoubleClick += P_MouseDoubleClick;
                    P.MouseClick += P_MouseClick;
                    flowLayoutPanel3.Controls.Add(P);

                    Label L = new Label()
                    {
                        Font = new Font("Century Gothic", 12, FontStyle.Bold),
                        Text = boadd2[0],
                        Margin = new Padding(0, 25, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };
                    P.Controls.Add(L);

                    Label L2 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[1],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L2);

                    Label L3 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[2],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L3);
                    Label L4 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[3],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L4);
                    Label L5 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[5],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                //    P.Controls.Add(L5);
                    Program.Server = null;
                    P.MouseDoubleClick+=P_MouseDoubleClick;
                }
            }
        }

        void P_MouseClick(object sender, MouseEventArgs e)
        {
            

            if (Program.Uname=="Student")
            {
                Program.MyBookName = ((Panel)sender).Name;
                MyBook MB = new MyBook();
                MB.Show();
 
            }
                
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Program.Server = "Category";
            this.Close();
        }

        private void Library_Enter(object sender, EventArgs e)
        {
        }

        private void Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.Server=="Category")
            {
                Category CA = new Category();
                CA.Show();
            } if (Program.Server=="BooksAdd")
            {
                Booksadd BA = new Booksadd();
                BA.Show();
            } if (Program.Server=="Remove")
            {
                Remove R = new Remove();
                R.Show();
            } if (Program.Server=="Booksupdate")
            {
                BooksUpdate Up = new BooksUpdate();
                Up.Show();
            } 
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Program.Server = "BooksAdd";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            String SS = ((Button)sender).Name;
            if (File.Exists(Program.Dir + @"\Booksadd.txt"))
            {
                string[] boadd = File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
                for (int i = 0; i < boadd.Length; i++)
                {
                    string[] boadd2 = boadd[i].Split('\t');
                    FlowLayoutPanel P = new FlowLayoutPanel()
                      {
                          Name = boadd2[4],
                          AutoSizeMode = AutoSizeMode.GrowAndShrink,
                          FlowDirection = FlowDirection.TopDown,
                          Cursor = Cursors.Hand,
                          //    BorderStyle = BorderStyle.FixedSingle,
                          BackColor = Color.Tomato,
                          Size = new Size(319, 229),
                      };

                   // P.MouseDoubleClick += P_MouseDoubleClick;
                    P.MouseClick += P_MouseClick;
                    flowLayoutPanel3.Controls.Add(P);

                    Label L = new Label()
                    {
                        Font = new Font("Century Gothic", 12, FontStyle.Bold),
                        Text = boadd2[0],
                        Margin = new Padding(0, 25, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };
                    P.Controls.Add(L);

                    Label L2 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[1],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L2);

                    Label L3 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[2],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L3);
                    Label L4 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[3],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L4);
                    Label L5 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[5],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    // P.Controls.Add(L5);
                    Program.Server = null;
                    P.MouseDoubleClick+=P_MouseDoubleClick;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string[]boadd=File.ReadAllLines(Program.Dir+@"\Booksadd.txt");
            for (int i = 0; i < boadd.Length; i++)
			{
			 string[]boadd2=boadd[i].Split('\t');
                if (boadd2[0]==textBox1.Text)
	{
		 flowLayoutPanel3.Controls.Clear();
                     FlowLayoutPanel P = new FlowLayoutPanel()
                    {
                        Name = boadd2[4],
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        FlowDirection = FlowDirection.TopDown,
                        Cursor = Cursors.Hand,
                      //  BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.Tomato,  
                      Size = new Size(319, 229),
                    };

                   //  P.MouseDoubleClick += P_MouseDoubleClick;
                     P.MouseClick += P_MouseClick;
                    flowLayoutPanel3.Controls.Add(P);

                    Label L = new Label()
                    {
                        Font = new Font("Century Gothic", 12, FontStyle.Bold),
                        Text = boadd2[0],
                        Margin = new Padding(0, 25, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };
                    P.Controls.Add(L);

                    Label L2 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[1],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L2);

                    Label L3 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[2],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L3);
                    Label L4 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[3],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };

                    P.Controls.Add(L4);
                    Label L5 = new Label()
                    {
                        Font = new Font("Century Gothic", 9, FontStyle.Regular),
                        Text = boadd2[5],
                        Margin = new Padding(0, 0, 0, 25),
                        ForeColor = SystemColors.ButtonHighlight,
                        Size = new Size(298, 23),
                    };
                    P.MouseDoubleClick+=P_MouseDoubleClick;
                   // P.Controls.Add(L5);
	}
			}
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Program.Server = "Remove";
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Server = "Booksupdate";
            this.Close();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Program.Uname=="Student")
            {
                DashBoard DB = new DashBoard();
                DB.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UpdateInfo UI = new UpdateInfo();
            UI.Show();
        }

       
    }
}
