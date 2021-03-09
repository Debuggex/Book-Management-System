using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    static class Program
    {
        public static string Aname,Uname,author,bookn,publisher,edition,Dir,Cat,Path,Server,PDF,Default,MyBookName;
        public static string[] Category=null;
        public static string[] PermanentCategory;
        public static int count;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
            Application.Run(new Form1());
        }
    }
}
