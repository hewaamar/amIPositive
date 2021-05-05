using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int integer = Convert.ToInt32(integerInput.Text);

            if (integer > 0)
            {
                signOutput.Text = $"{integer} is a positive number";
            }
            else
            {
                signOutput.Text = $"{integer} is a negative number";
            }

            if (integer % 7 == 0)
            {
                divideOutput.Text = $"{integer} is divisible by 7";
            }
            else
            {
                divideOutput.Text = $"{integer} is not divisible by 7";
            }
        }
    }
}
