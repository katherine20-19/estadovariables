using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPASOASP
{
    
    public partial class Form1 : Form
    {
        private int uno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textNunero.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uno++;
            textNunero.Text = uno.ToString();


        }
    }
}
