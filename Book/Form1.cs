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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Tomato;
            panel2.ForeColor = SystemColors.ButtonHighlight;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ButtonHighlight;
            label6.ForeColor = SystemColors.ButtonHighlight;
            panel2.BackColor = Color.Tomato;
            panel2.ForeColor = SystemColors.ButtonHighlight;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Tomato;
            panel3.ForeColor = SystemColors.ButtonHighlight;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.ButtonHighlight;
            label5.ForeColor = SystemColors.ButtonHighlight;
            panel3.BackColor = Color.Tomato;
            panel3.ForeColor = SystemColors.ButtonHighlight;

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ButtonHighlight;
            label4.ForeColor = SystemColors.ButtonHighlight;
            panel4.BackColor = Color.Tomato;
            panel4.ForeColor = SystemColors.ButtonHighlight;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Tomato;
            panel4.ForeColor = SystemColors.ButtonHighlight;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            sign.Show();
            Form1 F = new Form1();
            F.Close();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Admin_log A = new Admin_log();
            A.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            StudentLogIn st = new StudentLogIn();
            st.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\" + @"Library") == false)
            {
                Directory.CreateDirectory(@"C:\" + @"Library");
                MessageBox.Show("You must first locate default Directory to acess Library");
                string S = "";
                FolderBrowserDialog Fb = new FolderBrowserDialog();
                Fb.ShowDialog();
                S = Fb.SelectedPath;
                if (S == "")
                {
                    Application.Exit();
                }
                else
                {
                    Program.Default = S;
                    File.WriteAllText(@"C:\" + @"Library" + @"\Path.txt", S);
                }
            }
             if (File.Exists(@"C:\" + @"Library" + @"\Path.txt"))
            {
                Program.Default = File.ReadAllText(@"C:\" + @"Library" + @"\Path.txt");
            }
             else
             {
                 MessageBox.Show("You must first locate default Directory to acess Library");
                 string S = "";
                 FolderBrowserDialog Fb = new FolderBrowserDialog();
                 Fb.ShowDialog();
                 S = Fb.SelectedPath;
                 if (S == "")
                 {
                     Application.Exit();
                 }
                 else
                 {
                     Program.Default = S;
                     File.WriteAllText(@"C:\" + @"Library" + @"\Path.txt", S);
                 }
             }
        }
    }
}
