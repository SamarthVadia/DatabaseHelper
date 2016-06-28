using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseHelper.DatabaseHelper dbhelper = new DatabaseHelper.DatabaseHelper("18.62.9.117", "18.62.9.117", "root", "w0lfg4ng", "BECIVDatabase");
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            string[] c = dbhelper.getLastNImageTimestamps(2);
            int b = 2;
        }
    }
}
