using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebWin1.ServiceReference1;

namespace WebWin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(textBox1.Text);
            Web1SoapClient obj = new Web1SoapClient();
            textBox2.Text=obj.Factorial(n).ToString();
        }
    }
}
