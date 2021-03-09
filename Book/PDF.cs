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
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void PDF_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Program.PDF))
            {
                axAcroPDF1.src = Program.PDF;
            }
            else
            {
                MessageBox.Show("File not Found" + Environment.NewLine + "Please update File Path");
            }
        }
    }
}
