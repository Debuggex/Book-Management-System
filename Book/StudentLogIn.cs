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
    public partial class StudentLogIn : Form
    {
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Dir = Program.Default + @"\Student\" + textBox1.Text + @"\";
            string s = Program.Dir + textBox1.Text + ".txt";
            if (File.Exists(s))
            {
                string[] file = File.ReadAllLines(s);

                if (file[1] == textBox2.Text)
                {
                    int x = file.Length - 2;
                    Program.Uname = file[x];
                    Program.Aname = textBox1.Text;
                    Program.count = 1;
                    Program.Server = "StudentLogin";

                    this.Close();


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

        private void StudentLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.Server == "StudentLogin")
            {
                DashBoard Db = new DashBoard();
                Db.Show();
            }
        }
    }
}
