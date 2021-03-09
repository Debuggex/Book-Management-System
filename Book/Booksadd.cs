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
    public partial class Booksadd : Form
    {
        public Booksadd()
        {
            InitializeComponent();
        }

        private void Booksadd_Load(object sender, EventArgs e)
        {
            if (File.Exists(Program.Dir+@"\Books.txt"))
            {
                string[] books = System.IO.File.ReadAllLines(Program.Dir + @"\Books.txt");
                var source = new AutoCompleteStringCollection();
                source.AddRange(books);
                textBox6.AutoCompleteCustomSource = source;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.ShowDialog();
            textBox5.Text = O.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.author = textBox2.Text;
            Program.bookn = textBox1.Text;
            Program.edition = textBox3.Text;
            Program.publisher = textBox4.Text;
            Program.Cat = textBox6.Text;
            Program.Path = textBox5.Text;
            if (File.Exists(Program.Dir+@"\Booksadd.txt"))
            {
                File.AppendAllText(Program.Dir + @"\Booksadd.txt", textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" +textBox4.Text+"\t"+ textBox5.Text + "\t" + textBox6.Text + Environment.NewLine);
            }
            else
            {
                File.WriteAllText(Program.Dir + @"\Booksadd.txt", textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\t" + textBox5.Text + "\t" + textBox6.Text + Environment.NewLine);
     
            }
            Program.Server = "BooksAdd";
            Program.count = 2;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
           textBox6.Text = "Select";
            this.Close();
            
        }

        private void Booksadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Library Lib = new Library();
            Lib.Show();
        }

        
    }
}
