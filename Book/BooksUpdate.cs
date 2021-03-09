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
    public partial class BooksUpdate : Form
    {
        public BooksUpdate()
        {
            InitializeComponent();
        }

        private void BooksUpdate_Load(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
           
            string[] boadd = System.IO.File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
            for (int i = 0; i < boadd.Length; i++)
            {
                string[] boadd2 = boadd[i].Split('\t');
                boadd[i] = boadd2[0];
            }
            source.AddRange(boadd);
            textBox1.AutoCompleteCustomSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.ShowDialog();
            textBox6.Text = O.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string S = "";
            S = S + textBox2.Text + "\t"; S = S + textBox3.Text + "\t"; S = S + textBox4.Text + "\t"; S = S + textBox5.Text + "\t"; S = S + textBox6.Text + "\t"; S = S + textBox7.Text;
            string[] boadd = System.IO.File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
            for (int i = 0; i < boadd.Length; i++)
            {
                string[] boadd2 = boadd[i].Split('\t');
                if (boadd2[0]==textBox2.Text)
                {
                    boadd[i] = S;
                }
            }
            if (System.IO.File.Exists(Program.Dir+@"\Booksadd.txt"))
            {
                System.IO.File.WriteAllLines(Program.Dir + @"\Booksadd.txt", boadd);
                this.Close();
            }
        }

        private void BooksUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Server = "AdminLogin";
            Library lib = new Library();
            lib.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boadd = System.IO.File.ReadAllLines(Program.Dir + @"\Booksadd.txt");
            for (int i = 0; i < boadd.Length; i++)
            {
                string[] boadd2 = boadd[i].Split('\t');
                if (boadd2[0]==textBox1.Text)
                {
                    textBox2.Text = boadd2[0];
                    textBox3.Text = boadd2[1];
                    textBox4.Text = boadd2[2];
                    textBox5.Text = boadd2[3];
                    textBox6.Text = boadd2[4];
                    textBox7.Text = boadd2[5];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
