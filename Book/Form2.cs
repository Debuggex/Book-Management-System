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
    public partial class Admin_log : Form
    {
        public Admin_log()
        {
            InitializeComponent();
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {



            Program.Dir =Program.Default+ @"\Admin\" + textBox1.Text+@"\";
            string s = Program.Dir+textBox1.Text + ".txt";
            if (File.Exists(s))
            {
                string[] file = File.ReadAllLines(s);
                
                if (file[1]==textBox2.Text)
                {
                    int x = file.Length - 2;
                    Program.Uname = file[x];
                    Program.Aname = textBox1.Text;
                    Program.count = 1;
                    Program.Server = "AdminLogin";
                   
                   Library L = new Library();
                    L.Show();
                    
                    
                }
                else
                {
                    textBox2.Text = string.Empty;
                    MessageBox.Show("Password is incorrect");
                }
            }
            else
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                MessageBox.Show("Username not found");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
