using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        string[] categories;
        private void Remove_Load(object sender, EventArgs e)
        {
             categories = System.IO.File.ReadAllLines(Program.Dir + @"\Book.txt");
            textBox1.Lines = categories;
        }

        private void Remove_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Program.Server = "AdminLogin";
            Library lib = new Library();
            lib.Show();
        }

        private void Remove_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text=="" && System.IO.File.Exists(Program.Dir+@"\Book.txt"))
            {
                System.IO.File.Delete(Program.Dir + @"\Book.txt");
            }
            else
            {
                System.IO.File.WriteAllLines(Program.Dir + @"\Book.txt", textBox1.Lines);
            }
            
            
        }
    }
}
