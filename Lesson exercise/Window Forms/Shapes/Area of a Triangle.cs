using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Area_of_a_Triangle : Form
    {
        public Area_of_a_Triangle()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double sideA = int.Parse(txtSideA.Text);
            double sideB = int.Parse(txtSideB.Text);
            double sideC = int.Parse(txtSideC.Text);
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s*(s-sideA)*(s-sideB)*(s-sideC));
            Answer.Text = area.ToString();

        }
    }
}
