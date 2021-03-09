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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Book
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            
            InitializeComponent();
        }
        public string number;
        
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Tomato;
            button1.ForeColor = SystemColors.ButtonHighlight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (comboBox2.Text == "Admin")
            {
                Directory.CreateDirectory(Program.Default+@"\Admin\" + textBox1.Text);
                Program.Dir = Program.Default+@"\Admin\" + textBox1.Text+@"\";
                string file =Program.Default+ @"\Admin\" + textBox1.Text +@"\"+ textBox1.Text + ".txt";
                if (File.Exists(file))
                {
                    MessageBox.Show("Username Already Exists");
                }
                else
                {
                    if (File.Exists("adminnumbers"))
                    {
                        number = File.ReadAllText("adminnumbers");
                        int xx = Convert.ToInt32(number);
                        xx++;
                        File.WriteAllText("adminnumbers", xx.ToString());
                    }
                    else
                    {
                        
                        File.WriteAllText("adminnumbers", "0");
                    }
                   
                    Program.Aname = textBox1.Text;
                    Program.Uname = textBox4.Text;
                    Program.count = 0;
                    System.IO.File.WriteAllText(file, textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + comboBox1.Text + Environment.NewLine + comboBox2.Text + Environment.NewLine + textBox4.Text+Environment.NewLine);
                   // File.AppendAllText(@"System\System.txt", textBox1.Text + Environment.NewLine);
                    if (File.Exists(Program.Default+@"\Admin.txt"))
                    {
                        File.AppendAllText(Program.Default + @"\Admin.txt", textBox1.Text + Environment.NewLine);
                    }
                    else
                    {
                        File.WriteAllText(Program.Default + @"\Admin.txt", textBox1.Text + Environment.NewLine);
                    }

                   // Program.Server = "SignUp";
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    comboBox1.Text = "Select";
                    comboBox2.Text = "Select";
                   // Form F = new  Form()
                   // {
                   //     Name =Program.Aname+"Library",
                   //     Size = new Size(1066, 523),
                   //     Text = Program.Aname+"Form",
                   // };
                   // Panel P = new Panel()
                   // {
                   //     Name = Program.Aname + "panel",
                   //     Dock = DockStyle.Top,
                   //     BackColor = Color.Tomato,
                   //     Size = new Size(1050, 60),
                   //     Location = new Point(0, 0),
                   // };
                   // TextBox T = new TextBox() { 
                   // Name =Program.Aname+"textbox",
                   // Font=new Font("Century Gothic",8),
                   // Location = new Point(324, 20),
                   // Size = new Size(364, 16),
                   // };

                   // PictureBox Pic = new PictureBox() { 
                   // Name=Program.Aname+"picturebox",
                   // Size =new Size(20,20),
                   // BackgroundImageLayout=ImageLayout.Zoom,
                   // Image = Image.FromFile("search.png"),
                   // Location = new Point(699, 20),
                   // BackColor=Color.Tomato,
                   // SizeMode=PictureBoxSizeMode.Zoom,
                   // Cursor=Cursors.Hand,
                   // };
                   // FlowLayoutPanel Fpp = new FlowLayoutPanel()
                   // {
                   //     Name = Program.Aname + "Flow1",
                   //     Dock = DockStyle.Top,
                   //     Size=new Size(1050, 100),
                   //     FlowDirection =FlowDirection.LeftToRight,
                   //     AutoSize=false,
                   //     AutoSizeMode=AutoSizeMode.GrowAndShrink,
                   //     Location=new Point(0, 60),
                   //     BackColor = Color.Transparent,
                   //     BorderStyle=BorderStyle.FixedSingle,
                   // };
                   // FlowLayoutPanel Fpp2 = new FlowLayoutPanel()
                   // {
                   //     Name = Program.Aname + "Flow1",
                   //     Dock = DockStyle.Fill,
                   //     //Size = new Size(1050, 100),
                   //     FlowDirection = FlowDirection.LeftToRight,
                   //     AutoSize = false,
                   //     AutoSizeMode = AutoSizeMode.GrowAndShrink,
                   //     //Location = new Point(0, 60),
                   //     BackColor = Color.Transparent,
                   //     BorderStyle = BorderStyle.FixedSingle,
                   // };

                   // Label LL = new Label() { 
                   // Name =Program.Aname+"label",
                   // Text=Program.Aname,
                   // Font=new Font("Century Gothic",9),
                   // Location = new Point(885, 20),
                   // BackColor=Color.Tomato,
                   // BorderStyle=BorderStyle.None,
                   // ForeColor=SystemColors.ButtonHighlight,
                   // };

                   // PictureBox PB = new PictureBox()
                   // {
                   //     Name = Program.Aname + "picture",
                   //     Size = new Size(30, 29),
                   //    // Location = new Point(3, 64),
                   //     Image = Image.FromFile("icons8-add-50.png"),
                   //     SizeMode = PictureBoxSizeMode.StretchImage,
                   //     Cursor = Cursors.Hand,
                   //     BackColor=Color.Transparent,

                   // }; PB.BringToFront();

                   // PictureBox PB2 = new PictureBox()
                   // {
                   //     Name = Program.Aname + "picture",
                   //     Size = new Size(30, 29),
                   //     // Location = new Point(3, 64),
                   //     Image = Image.FromFile("icons8-add-50.png"),
                   //     SizeMode = PictureBoxSizeMode.StretchImage,
                   //     Cursor = Cursors.Hand,
                   //     BackColor = Color.Transparent,

                   // }; PB.BringToFront();


                   // LL.BringToFront();
                   // Fpp.BringToFront();
                   // Fpp.Controls.Add(PB);
                   // Fpp2.Controls.Add(PB2);
                   // P.Controls.Add(T);
                   // F.Controls.Add(Pic);
                   // F.Controls.Add(LL);
                   // F.Controls.Add(Fpp2);
                   // F.Controls.Add(Fpp);
                   // F.Controls.Add(P);
                   // Pic.BringToFront();
                    
                   //// File.Create(Program.Aname + "Library" + ".cs");
                   // F.Show();



                    Program.Server = "SignUp";
                    this.Close();
                    
                }
            }
            else
            {

                Directory.CreateDirectory(Program.Default+@"\Student\" + textBox1.Text);
                Program.Dir =Program.Default+ @"\Student\" + textBox1.Text + @"\";
                string file = Program.Default+@"\Student\" + textBox1.Text + @"\" + textBox1.Text + ".txt";
                if (File.Exists(file))
                {
                    MessageBox.Show("Username Already Exists");
                }
                else
                {
                    

                    Program.Aname = textBox1.Text;
                    Program.Uname = textBox4.Text;
                    Program.count = 0;
                    System.IO.File.WriteAllText(file, textBox1.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + comboBox1.Text + Environment.NewLine + comboBox2.Text + Environment.NewLine + textBox4.Text + Environment.NewLine + number);
                 //   File.AppendAllText(@"System\System.txt", textBox1.Text + Environment.NewLine);
                    //if (File.Exists("Admin.txt"))
                    //{
                    //    File.AppendAllText("Admin.txt", textBox1.Text + Environment.NewLine);
                    //}
                    //else
                    //{
                    //    File.WriteAllText("Admin.txt", textBox1.Text + Environment.NewLine);
                    //}

                    Program.Server = "SignUp2";
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    comboBox1.Text = "Select";
                    comboBox2.Text = "Select";

                    this.Close();
                }
            }
            
            
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != string.Empty)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty || comboBox1.Text != "Select" || comboBox2.Text != "Select")
            {
                textBox3.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;

            }
            else
            {
                textBox3.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Enabled==true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Sign_Up_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Program.Server=="SignUp")
            //{
            //    Library Lib = new Library();
            //Lib.Show();
            //}
            //else if(Program.Server=="SignUp2")
            //{
            //    DashBoard DB = new DashBoard();
            //    DB.Show();
            //}
            
        }

       
    }
}
