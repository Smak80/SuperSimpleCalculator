using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperSimpleCalculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void operation_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = double.Parse(tbNum1.Text);
            } catch (Exception ex)
            {
                a = 0.0;
            }
            try
            {
                b = double.Parse(tbNum2.Text);
            } catch (Exception ex)
            {
                b = 0.0;
            }

            double c = 0;
            if (((Button) sender).Name == "btnPlus")
            {
                c = a + b;
            } else if (((Button) sender).Name == "btnMinus")
            {
                c = a - b;
            } else if (((Button) sender).Name == "btnTimes")
            {
                c = a * b;
            } else if (((Button) sender).Name == "btnDiv")
            {
                c = a / b;
            }

            lblResult.Text = "Результат: " + c;
        }
    }
}
