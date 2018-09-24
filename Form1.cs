using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// Just add a button to a blank form and you're good to go C#
        private void button1_Click(object sender, EventArgs e)
        {
            string helloWorld = "Hello World";
            MessageBox.Show(helloWorld, "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
