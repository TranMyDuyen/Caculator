using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text.ToString());
            int b = int.Parse(txtB.Text.ToString());
            Calculation c = new Calculation(a, b);

            txtRes.Text = c.Execute("+").ToString();

            //if (txtA.Text != String.Empty)
            //{
            //    double a = double.Parse(txtA.Text);
            //    double b = double.Parse(txtB.Text);
            //    double c = a + b;
            //    txtRes.Text = c.ToString();
            //}
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtRes.Text = c.ToString();
        }
    }
}
