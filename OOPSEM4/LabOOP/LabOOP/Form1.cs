using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultS_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int s = a * a;
            ResultS.Text = Convert.ToString(s);

        }

        private void buttonResultP_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int p = a * 4;
            ResultP.Text = Convert.ToString(p);
        }
    }
}
