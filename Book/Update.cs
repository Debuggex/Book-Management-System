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
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Program.Default+@"\"+Program.Uname+@"\"+Program.Aname+@"\"+Program.Aname+".txt"))
            {
                textBox1.Lines = System.IO.File.ReadAllLines(Program.Default + @"\" + Program.Uname + @"\" + Program.Aname + @"\" + Program.Aname + ".txt");
            }
            else
            {
                MessageBox.Show("Info Not Found!");
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines(Program.Default + @"\" + Program.Uname + @"\" + Program.Aname + @"\" + Program.Aname + ".txt", textBox1.Lines);
            this.Close();
        }
        
    }
}
