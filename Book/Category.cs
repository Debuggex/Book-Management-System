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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Category = textBox1.Lines;
            if (System.IO.File.Exists(Program.Dir+@"\Book.txt"))
            {
                System.IO.File.AppendAllLines(Program.Dir + @"\Book.txt", Program.Category);
            }else
	{
                System.IO.File.WriteAllLines(Program.Dir + @"\Book.txt", Program.Category);
	}
            Program.PermanentCategory = System.IO.File.ReadAllLines(Program.Dir + @"\Book.txt");
            
            textBox1.Text = string.Empty;
            Program.Server = "Category";
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            

        }

        private void Category_FormClosed(object sender, FormClosedEventArgs e)
        {
            Library Lib = new Library();
            Lib.Show();
            Lib.BringToFront();
            Lib.Focus();
        }
    }
}
